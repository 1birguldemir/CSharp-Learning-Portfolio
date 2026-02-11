using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__
{
    internal class uygulama6
    {/*
        static void Main(string[] args)
        {
            
            int remain;
            string binary="";
            Console.WriteLine("Enter the decimal number:");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                remain = number % 2;
                binary = remain.ToString() + binary;
                number = number / 2;

            }
            Console.WriteLine("Binary: {0}",binary);


            int employee=1;
            double gross;
            double rate=0,net;
            Console.WriteLine("--You can exit with 0--");
            do
            {
                Console.WriteLine("Enter the gross salary for {0}.employee",employee);
                gross = int.Parse(Console.ReadLine());
                if (gross==0)
                {
                    break;
                }
                employee++;
                if (gross >= 15000 && gross <= 20000)
                {
                    rate = 0.1;
                }
                else if (gross >= 20001 && gross <= 30000)
                {
                    rate = 0.12;
                }
                else if (gross >= 30001 && gross <= 49999)
                {
                    rate = 0.15;
                }
                else if (gross >= 50000)
                { rate = 0.2; }
                else
                    rate = 0;

                net = (gross - (gross * rate)) - 150.5;
                Console.WriteLine($"Net salary: {net:F2}");
            } while (gross!=0);



            int lowest;
            Console.WriteLine("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int second = int.Parse(Console.ReadLine());
            bool flag = true;
            if (first > second)
            {
                lowest = second;
            }
            else
            {
                lowest = first;
            }

            for (int i = 2; i < lowest; i++)
            {
                if (first % i == 0 && second % i == 0)
                {
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine("These numbers are coprimes");
            }
            else
            {
                Console.WriteLine("These numbers are not coprimes");
            }


            Console.WriteLine("Which one is the highest mountain in Turkey?" +
                "\nA) KAZ MOUNTAINS B) AMANOSES C) AĞRI MOUNTAIN D) NEMRUT MOUNTAIN");
            char q1 = char.Parse(Console.ReadLine());
            
            

            if (q1 == 'C')
            {
                Console.WriteLine("You answered right");
                Console.WriteLine("Who is the first known woman computer programmer?" +
                "\nA) MARIE CURIE B) ADA LOVELACE C) PARISA TABRIZ D) CELINE DION");
                char q2 = char.Parse(Console.ReadLine());
                if (q2 == 'B')
                {
                    Console.WriteLine("You answered right");
                    Console.WriteLine("When was the latest championship that Fenerbahçe won?" +
                "\nA) 2012-2013 B) 2013-2014 C) 2014-2015 D) 2015-2016\"");
                    char q3 = char.Parse(Console.ReadLine());
                    if (q3 == 'B')
                    {
                        Console.WriteLine("You won the 1M!");
                    }
                    else { Console.WriteLine("You lost the game :("); }
                }
                else { Console.WriteLine("You lost the game :("); }
            }
            else { Console.WriteLine("You lost the game :("); }


            int counter =0,countAPlus=0,countA=0,countB = 0,countC = 0,countBPlus = 0,countD = 0,countE = 0,countF = 0;
            Console.Write("Enter the size of the class: ");
            int classSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the grades: ");
            while (counter < classSize)
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade < 0|| grade > 100) {
                    Console.WriteLine("Invalid grade.");
                    continue;
                }
                counter++;
                if (grade<=40)
                {
                    countF++;
                }
                else if (grade <= 50)
                {
                    countE++;
                }
                else if (grade <= 60)
                {
                    countD++;
                }else if (grade <= 70)
                {
                    countC++;
                }
                else if (grade <= 80)
                {
                    countB++;
                }
                else if (grade <= 90)
                {
                    countBPlus++;
                }
                else if (grade <= 95)
                {
                    countA++;
                }
                else 
                {
                    countAPlus++;
                }
                
            }
                int pass = countC+countBPlus+countD+countE+countB+countA+countAPlus;
                int fail = countF;
                Console.WriteLine("{0} has passed the class {1} has failed",pass,fail);
                Console.WriteLine("Number of A+ is "+countAPlus);
                Console.WriteLine("Number of A is " + countA);
                Console.WriteLine("Number of B+ is " + countBPlus);
                Console.WriteLine("Number of B is " + countB);
                Console.WriteLine("Number of C is " + countC);
                Console.WriteLine("Number of D is " + countD);
                Console.WriteLine("Number of E is " + countE);
                Console.WriteLine("Number of F is " + countF);
            
        }*/
    }
}
