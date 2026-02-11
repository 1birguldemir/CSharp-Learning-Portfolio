using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__
{
    internal class uygulama5
    {
        /*
        static void Main(string[] args)
        {
            
            int pow = 1, fact = 1;
            Console.WriteLine("Enter the numer x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number y:");
            int y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++)
            {
                pow *= x;
            }
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            Console.WriteLine("x!:{0}", fact);
            Console.WriteLine("x^y:{0}", pow);
            double res = (double)pow / fact;
            Console.WriteLine("The result is {0} ",res);


            Console.WriteLine("Enter the number to check if it is prime: ");
            int prime = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (prime < 2)
            {
                isPrime = false;
            }

            for (int i = 2; i <= prime/2; i++)
            {
                if (prime % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("The number is prime");
            }
            else { Console.WriteLine("The number is not prime"); }


            Random rnd = new Random();
            int dice = rnd.Next(1,7);

            bool isWin = false;

            for (int i = 3; i > 0; i--)
            {
                Console.Write("You have {0} rights. Please enter your guess: ",i);
                int guess = int.Parse(Console.ReadLine());
                if (dice == guess)
                {
                    Console.WriteLine("You win the game!");
                    isWin = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Your guess is not right!");
                }
            }
            if (isWin == false) { 
            Console.WriteLine("You lost the game. Correct number was {0}",dice);}

            int number;
            int sum = 0;
            Console.WriteLine("Enter the numbers for summation:");
            do
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            } while (number!=0);

            Console.WriteLine(sum);


            int counter = 0;
            int number;
            double sum = 0;
            while (counter<5) {
                Console.WriteLine("Enter the {0}. positive number: ",counter+1);
                number = int.Parse(Console.ReadLine());
                if (number>0)
                {
                    counter++;
                    sum += number;
                }
            }
            double avrg = sum / 5;
            Console.WriteLine("The result is {0:0.00}",avrg);


            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}x{1}={2}",i,j,i*j);
                    
                }Console.WriteLine("------------------------------");
            }
        }*/
    }
}
