using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text;

namespace CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example: 4388576018410703
            long number = TakeCardNumber();
            if (number == 0)
            {
                Console.WriteLine("Invalid input. Program ended.");
                return;
            }

            bool lengthFlag = CheckLength(number);

            int oddresult = SumOfOdds(number);
            int evenresult = SumOfEvens(number);

            bool divisible = IsDivisible(evenresult, oddresult);

            if (lengthFlag && divisible)
            {
                Console.WriteLine(
                    "Credit Card number is valid! this card has {0}...",
                    BelongsTo(number)
                );
            }
            else
            {
                Console.WriteLine("Credit Card number is not valid!");
            }

            Console.ReadLine();
        }

        // STRINGBUILDER ile kart numarası alma
        static long TakeCardNumber()
        {
            StringBuilder sb = new StringBuilder();
            Console.Write("Please enter a credit card number: ");
            string input = Console.ReadLine();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    sb.Append(c);
                }
                else
                {
                    Console.WriteLine("Only digits are allowed!");
                    return 0;
                }
            }

            if (sb.Length != 16)
            {
                Console.WriteLine("Credit card number must be exactly 16 digits!");
                return 0;
            }

            return long.Parse(sb.ToString());
        }

        static bool CheckLength(long number)
        {
            return number.ToString().Length == 16;
        }

        static int SumOfEvens(long number)
        {
            string new_number = number.ToString();
            int sum = 0;

            for (int i = 1; i < new_number.Length; i += 2)
            {
                int digit = int.Parse(new_number[i].ToString()) * 2;
                if (digit > 9)
                    digit = (digit / 10) + (digit % 10);

                sum += digit;
            }

            return sum;
        }

        static int SumOfOdds(long number)
        {
            string new_number = number.ToString();
            int sum = 0;

            for (int i = 0; i < new_number.Length; i += 2)
            {
                sum += int.Parse(new_number[i].ToString());
            }

            return sum;
        }

        static bool IsDivisible(int sumOfEvens, int sumOfOdds)
        {
            return (sumOfEvens + sumOfOdds) % 10 == 0;
        }

        static string BelongsTo(long number)
        {
            string newnumber = number.ToString();
            string starts_with = "" + newnumber[0] + newnumber[1];

            if (starts_with == "43")
                return "a Visa logo";
            else if (starts_with == "42")
                return "a MasterCard logo";
            else
                return "no logo";
        }
    }
}