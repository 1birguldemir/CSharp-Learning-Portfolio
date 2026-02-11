using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__
{
    internal class uygulama8
    {/*
        static void Main(String[] args)
        {
            
            Console.Write("Please enter nuber of rows and columns:");
            int size = int.Parse(Console.ReadLine());
            int[,] arr = new int[size, size];

            Random rnd = new Random();

            Console.WriteLine("The original matrix: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = rnd.Next(0, 21);
                    Console.Write("\t{0}",arr[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("The transposed matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("\t{0}", arr[j, i]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("The summation of the matrices");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("\t{0}", arr[j, i] + arr[i,j]);
                }
                Console.WriteLine();
            }

            char temp;
            int frow, fcol, lrow, lcol;
            char[,] latin = new char[13, 2];
            char letter = 'a';
            Random rnd = new Random();
            Console.WriteLine("The orijinal char array:");
            for (int i = 0; i < latin.GetLength(0); i++)
            {
                for (int j = 0; j < latin.GetLength(1); j++)
                {
                    latin[i, j] = letter;
                    
                    Console.Write("({0},{1}): {2}\t", i, j, latin[i,j]);
                    letter++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("The shuffled array:");
            for(int i = 0;i < 10; i++)
            {
                frow = rnd.Next(latin.GetLength(0));
                fcol = rnd.Next(latin.GetLength(1));
                lrow = rnd.Next(latin.GetLength(0));
                lcol = rnd.Next(latin.GetLength(1));


                temp = latin[frow, fcol];
                latin[frow, fcol] = latin[lrow, lcol];
                latin[lrow,lcol] = temp;
            }

            for (int i = 0; i < latin.GetLength(0); i++)
            {
                for (int j = 0; j < latin.GetLength(1); j++)
                {
                    Console.Write("({0},{1}): {2}\t", i, j, latin[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            foreach (char c in word)
            {
                for (int i  = 0; i < latin.GetLength(0); i++)
                {
                    for (int j = 0; j < latin.GetLength(1); j++)
                    {
                        if (c == latin[i, j]) { 
                        Console.WriteLine("{0} is at index ({1},{2})", c, i, j);
                            break;
                        }
                    }
                }
            }

            int num;
            string stdN,stdL,status;
            double midterm, final,totalMid=0,totalFin=0,avarage=0;
            Console.Write("Number of students: ");
            num = int.Parse(Console.ReadLine());
            string[,] name_and_lastname= new string[num,2];
            double[,] exams = new double[num+1,3];
            for (int i = 0; i < num; i++)
            {
                Console.Write("Student {0} first name: ",i+1);
                stdN = Console.ReadLine();
                Console.Write("Student {0} last name: ", i + 1);
                stdL = Console.ReadLine();
                name_and_lastname[i, 0] = stdN;
                name_and_lastname[i,1] = stdL;
            }
            for (int i = 0; i < num; i++)
            {
                Console.Write("{0} {1} - Midterm:", name_and_lastname[i, 0], name_and_lastname[i, 1]);
                midterm = double.Parse(Console.ReadLine());
                Console.Write("{0} {1} - Final:", name_and_lastname[i, 0], name_and_lastname[i,1]);
                final = double.Parse(Console.ReadLine());
                avarage = (midterm*0.4)+(final*0.6);
                exams[i, 0] = midterm;
                exams[i,1] = final;
                exams[i,2] = avarage;
                totalMid += midterm;
                totalFin += final; 
            }
            exams[num, 0] = totalMid / num;
            exams[num,1] = totalFin / num;

            Console.WriteLine("Name Surname                    Midterm          Final          Average          Status");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            for (int i = 0; i < num; i++)
            {
                string students = name_and_lastname[i, 0] + " " + name_and_lastname[i, 1];
                if (exams[i,2] >= 40)
                {
                    status = "Passed";
                }
                else
                {
                    status = "Failed";
                }
                Console.WriteLine("{0,-40}{1,-20:F2}{2,-20:F2}{3,-20:F2}{4,-20:F2}", students, exams[i, 0], exams[i, 1], exams[i, 2], status);
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("{AVERAGE,-40}{0,-20:F2}{1,-20:F2}", exams[num,0],exams[num,1]);
        }*/
    }
}
