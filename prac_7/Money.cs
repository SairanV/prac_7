using System;

namespace prac_7
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money operator +(Money a, Money b)
        {
            if (a.Currency == b.Currency)
            {
                return new Money(a.Amount + b.Amount, a.Currency);
            }
            else
            {
                decimal convertedAmount = ConvertCurrency(b, a.Currency);
                return new Money(a.Amount + convertedAmount, a.Currency);
            }
        }

        private static decimal ConvertCurrency(Money money, string targetCurrency)
        {
            if (money.Currency == "USD" && targetCurrency == "EUR")
            {
                return money.Amount * 0.85M;
            }
            else if (money.Currency == "EUR" && targetCurrency == "USD")
            {
                return money.Amount / 0.85M;
            }
            throw new InvalidOperationException("Currency conversion is not supported for the provided currencies.");
        }

        public static bool operator ==(Money a, Money b)
        {
            return a.Amount == b.Amount && a.Currency == b.Currency;
        }

        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }
    }
}
