using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__
{
    internal class uygulama7
    {/*
        static void Main(string[] args)
        {
            
            int size1, size2,count=0;
            Console.WriteLine("Enter the size of the array1:");
            size1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the array2:");
            size2 = int.Parse(Console.ReadLine());

            int[] arr1 = new int[size1];
            int[] arr2 = new int[size2];

            for (int i = 0; i < size1; i++)
            {
                Console.WriteLine("Enter the {0}. element of array1:",i+1);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size2; i++)
            {
                Console.WriteLine("Enter the {0}. element of array2:", i + 1);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            if (arr1.Length==arr2.Length)
            {
                while (size1 > count)
                {
                    if (arr1[count] == arr2[count])
                    {
                        count++;
                    }
                    else
                        break;
                }
                Console.WriteLine(size1==count?"They are the same":"They are not same.");
            }
            else { Console.WriteLine("They are not same."); }


            int[] arr1 = new int[5];
            arr1[0] = 10;
            arr1[1] = 20;
            arr1[2] = 30;
            arr1[3] = 40;
            arr1[4] = 50;

            int[] arr2 = new int[5];
            arr2[0] = 1;
            arr2[1] = 2;
            arr2[2] = 3;
            arr2[3] = 4;
            arr2[4] = 5;

            int[] arrSum = new int[5];
            Console.WriteLine("Sum of arrays: ");
            for (int i = 0; i < arr1.Length; i++) { 
                arrSum[i] = arr1[i]+arr2[i];
                Console.WriteLine($"arrSum[{i}]: {arrSum[i]}");


            bool[] mines = new bool[10];
            int count = 0;
            Random rnd = new Random();

            Console.WriteLine("Mines are placing.");
            while (count < 2) {
                int rand = rnd.Next(0, 10);
                if (!mines[rand]) { 
                    mines[rand] = true;
                    count++;
                }   
            }
            Console.WriteLine("Mines have been placed.");
            Console.WriteLine("The game has started.");


            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter an index between 0-9: ");
                int index = int.Parse(Console.ReadLine());
                if (mines[index])
                {
                    Console.WriteLine("The mine exploded. You lost!");
                    return;
                }
            }
            Console.WriteLine("You win!");


            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(0,100);
                
            }
            Console.Write("The created array is: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.Write("\nThe elements are bigger than their neighbors are:");
            for (int i = 1;i < arr.Length-1; i++)
            {
                if(arr[i] > arr[i - 1] && arr[i] > arr[i+1])
                {
                    Console.Write(arr[i]+" ");
                }
            }


            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            int count = 0;
            sentence = sentence.ToLower();

            char[] vowels = { 'a', 'e', 'o', 'i', 'u' };
            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    {
                        if (sentence[i] == vowels[j])
                        count++;
                    } 
                }
            }
            Console.WriteLine($"There are {count} vowels in this sentence");


            string str = "Software.Engineering.Department";
            string[] splits;

            splits = str.Split('.');
            Console.WriteLine("The full string was: "+str);
            for (int i = 0; i < splits.Length; i++) {
                Console.WriteLine($"The {i+1}. splitted string is {splits[i]}");
            }
        }*/
    }
}
