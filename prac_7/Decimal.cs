using System;
using System.Linq;

internal class Decimal
{
    private char[] digits;

    public Decimal(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Value cannot be null or empty.");
        }

        if (!IsNumericString(value))
        {
            throw new ArgumentException("Value must contain only numeric characters.");
        }

        digits = value.ToCharArray();
    }

    private bool IsNumericString(string value)
    {
        foreach (char c in value)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }

    public static Decimal operator +(Decimal a, Decimal b)
    {
        int maxLength = Math.Max(a.digits.Length, b.digits.Length);
        char[] resultDigits = new char[maxLength + 1];

        int carry = 0;
        for (int i = 0; i < maxLength; i++)
        {
            int digitA = i < a.digits.Length ? a.digits[i] - '0' : 0;
            int digitB = i < b.digits.Length ? b.digits[i] - '0' : 0;

            int sum = digitA + digitB + carry;
            resultDigits[i] = (char)((sum % 10) + '0');
            carry = sum / 10;
        }

        if (carry > 0)
        {
            resultDigits[maxLength] = (char)(carry + '0');
        }

        return new Decimal(new string(resultDigits));
    }

    public static Decimal operator -(Decimal a, Decimal b)
    {
        int maxLength = Math.Max(a.digits.Length, b.digits.Length);
        char[] resultDigits = new char[maxLength];

        int borrow = 0;
        for (int i = 0; i < maxLength; i++)
        {
            int digitA = i < a.digits.Length ? a.digits[i] - '0' : 0;
            int digitB = i < b.digits.Length ? b.digits[i] - '0' : 0;

            int diff = digitA - digitB - borrow;
            if (diff < 0)
            {
                diff += 10;
                borrow = 1;
            }
            else
            {
                borrow = 0;
            }

            resultDigits[i] = (char)(diff + '0');
        }

        resultDigits = resultDigits.Reverse().SkipWhile(c => c == '0').Reverse().ToArray();

        return new Decimal(new string(resultDigits));
    }

    public static Decimal operator *(Decimal a, Decimal b)
    {
        int lenA = a.digits.Length;
        int lenB = b.digits.Length;
        char[] resultDigits = new char[lenA + lenB];

        for (int i = 0; i < lenA; i++)
        {
            int carry = 0;
            int digitA = a.digits[i] - '0';

            for (int j = 0; j < lenB; j++)
            {
                int digitB = b.digits[j] - '0';
                int product = digitA * digitB + (resultDigits[i + j] - '0') + carry;
                carry = product / 10;
                resultDigits[i + j] = (char)((product % 10) + '0');
            }

            resultDigits[i + lenB] = (char)(carry + '0');
        }

        resultDigits = resultDigits.Reverse().SkipWhile(c => c == '0').Reverse().ToArray();

        return new Decimal(new string(resultDigits));
    }

    public static Decimal operator /(Decimal a, Decimal b)
    {
        if (b == new Decimal("0"))
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        Decimal quotient = new Decimal("0");
        Decimal remainder = new Decimal(a.ToString());

        while (remainder.CompareTo(b) >= 0)
        {
            Decimal step = new Decimal("1");
            Decimal temp = new Decimal(b.ToString());

            while (remainder.CompareTo(temp + temp) >= 0)
            {
                temp += temp;
                step += step;
            }

            remainder -= temp;
            quotient += step;
        }

        return quotient;
    }

    public override string ToString()
    {
        return new string(digits);
    }

    public static bool operator ==(Decimal a, Decimal b)
    {
        return a.ToString() == b.ToString();
    }

    public static bool operator !=(Decimal a, Decimal b)
    {
        return !(a == b);
    }

    public int CompareTo(Decimal other)
    {
        if (this.digits.Length < other.digits.Length)
        {
            return -1;
        }
        else if (this.digits.Length > other.digits.Length)
        {
            return 1;
        }
        else
        {
            for (int i = 0; i < this.digits.Length; i++)
            {
                if (this.digits[i] < other.digits[i])
                {
                    return -1;
                }
                else if (this.digits[i] > other.digits[i])
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
