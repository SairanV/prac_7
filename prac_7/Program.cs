using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 question: ");

            ClassProperties obj1 = new ClassProperties(10);
            ClassProperties obj2 = new ClassProperties(20);

            Console.WriteLine(obj1 == obj2); // Output: False
            Console.WriteLine(obj1 != obj2); // Output: True

            Console.WriteLine();
            Console.WriteLine("2 question: ");

            ClassWithArray objArr1 = new ClassWithArray(new int[] { 1, 2, 3 });
            ClassWithArray objArr2 = new ClassWithArray(new int[] { 4, 5, 6 });

            Console.WriteLine(objArr1 < objArr2); // Output: True
            Console.WriteLine(objArr1 > objArr2); // Output: False

            Console.WriteLine();
            Console.WriteLine("3 question: ");

            Money money1 = new Money(100, "USD");
            Money money2 = new Money(50, "USD");
            Money money3 = new Money(70, "EUR");

            Money sum1 = money1 + money2;
            Money sum2 = money1 + money3;

            Console.WriteLine(sum1.Amount); // Output: 150
            Console.WriteLine(sum2.Amount); // Output: 100

            Console.WriteLine(money1 == money2); // Output: False
            Console.WriteLine(money1 != money2); // Output: True

            Console.WriteLine();
            Console.WriteLine("4 question: ");

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            OneDimArray array1 = new OneDimArray(arr1);
            OneDimArray array2 = new OneDimArray(arr2);

            int result = array1 * array2;
            Console.WriteLine("Result of multiplication: " + result);

            bool areEqual = (array1 == array2);
            Console.WriteLine("Arrays are equal: " + areEqual);

            bool lessOrEqual = (array1 <= array2);
            Console.WriteLine("Array1 is less than or equal to Array2: " + lessOrEqual);

            Console.WriteLine();
            Console.WriteLine("5 question: ");

            int[] arrDA1 = { 1, 2, 3 };
            int[] arrDA2 = { 4, 5, 6 };

            OneDimArray arrayDA1 = new OneDimArray(arrDA1);
            OneDimArray arrayDA2 = new OneDimArray(arrDA2);

            int resultDA = arrayDA1 * arrayDA2;
            Console.WriteLine("Result of multiplication: " + resultDA);

            bool areEqualDA = (arrayDA1 == arrayDA2);
            Console.WriteLine("Arrays are equal: " + areEqual);

            bool lessOrEqualDA = (arrayDA1 <= arrayDA2);
            Console.WriteLine("Array1 is less than or equal to Array2: " + lessOrEqualDA);

            Console.WriteLine();
            Console.WriteLine("6 question: ");
            /*
            Decimal numD1 = new Decimal("12345");
            Decimal numD2 = new Decimal("12345");

            Decimal sumD = numD1 + numD2;
            Decimal differenceD = numD1 - numD2;
            Decimal productD = numD1 * numD2;
            Decimal quotientD = numD1 / numD2;

            Console.WriteLine("Sum: " + sumD);
            Console.WriteLine("Difference: " + differenceD);
            Console.WriteLine("Product: " + productD);
            Console.WriteLine("Quotient: " + quotientD);

            Console.WriteLine("Are num1 and num2 equal? " + (numD1 == numD2));
            */

            Console.WriteLine();
            Console.WriteLine("7 question: ");

            Complex complex1 = new Complex(3.0, 4.0);
            Complex complex2 = new Complex(1.0, 2.0);

            Complex sumC = complex1 + complex2;
            Complex differenceC = complex1 - complex2;
            Complex productC = complex1 * complex2;
            Complex quotientC = complex1 / complex2;

            Complex realPlusComplex = 2.0 + complex1;

            Console.WriteLine("Sum: " + sumC);
            Console.WriteLine("Difference: " + differenceC);
            Console.WriteLine("Product: " + productC);
            Console.WriteLine("Quotient: " + quotientC);
            Console.WriteLine("Real + Complex: " + realPlusComplex);

            Console.WriteLine("Are complex1 and complex2 equal? " + (complex1 == complex2));

            Console.WriteLine();
            Console.WriteLine("8 question: ");

            Frac frac1 = new Frac(1, 2);
            Frac frac2 = new Frac(3, 4);

            Frac sumF = frac1 + frac2;
            Frac differenceF = frac1 - frac2;
            Frac productF = frac1 * frac2;
            Frac quotientF = frac1 / frac2;

            double doubleValueF = (double)frac1;

            bool areEqualF = (frac1 == frac2);

            double resultF = frac1.Evaluate(2.0);
            Console.WriteLine("Sum: " + sumF);
            Console.WriteLine("Difference: " + differenceF);
            Console.WriteLine("Product: " + productF);
            Console.WriteLine("Quotient: " + quotientF);
            Console.WriteLine("Double Value: " + doubleValueF);
            Console.WriteLine("Are Frac1 and Frac2 equal? " + areEqualF);
            Console.WriteLine("Result of evaluating Frac1 at x=2.0: " + resultF);

        }
    }
}
