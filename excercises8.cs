using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__
{
    internal class uygulama9
    {
        static void Main(String[] args)
        {/*
            Console.WriteLine("Please enter a character: ");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine("The ASCII value of {0} is {1}",c,ConvertCharToInt(c));


            Console.WriteLine("Enter the base number:");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power of the number:");
            int power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The {0}. power of {1} is {2}",power,baseNum,CalculatePower(baseNum,power));
            


            Console.WriteLine("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("C({0},{1}) = {2}",first,second,CalculateCombination(first,second));



            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("The longest element in the string is {0}",FindLongestWord(str));
            */



            Console.WriteLine("The decimal value is: "+ConvertBinaryToDecimal(1,0,1,0,1));
        }
        static string ConvertBinaryToDecimal(params int[] bin)
        {

        }
        
        
        /*
        static string FindLongestWord(string word)
        {
            string[] words = word.Split(' ');
            string longest = words[0];
            for (int i = 0; i < words.Length; i++)
            {
                if (longest.Length < words[i].Length)
                {
                    longest = words[i];
                }
            }
            return longest.ToUpper();
        }
        

        
        static int CalculateFactorial(int a)
        {
            int factorial = 1;
            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static int CalculateCombination(int a,int b)
        {
            int comb = CalculateFactorial(a)/(CalculateFactorial(a-b)*CalculateFactorial(b));
            return comb;
        }
        
        
        static int CalculatePower(int a,int pow)
        {
            int value = (int)Math.Pow(a, pow);
            return value;
        }


        
        static int ConvertCharToInt(char c) {
            return (int)c;
        }*/
    }
}
