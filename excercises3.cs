using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__
{
    internal class uygulama4
    {
        //static void Main(string[] args)
        //{
            /*
            Console.WriteLine("Please enter a and b:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int temp;

            if (b > a)
            {
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("I swapped a and b. The a is {0} and the b is {1}",a,b);
            }else
                Console.WriteLine("The a is {0} and the b is {1}",a,b);
            */


            /*
            Console.WriteLine("Please enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number: ");
            int c = int.Parse(Console.ReadLine());
            int smallest = c;
            if (b > a && c > a)
            {
                smallest = a;
            }
            else if (a > b && c > b)
            {
                smallest = b;
            }
            else
                smallest = c;

            Console.WriteLine("The smallest number is {0}",smallest);*/

            /*
            Console.WriteLine("Please enter your birth year: ");
            int birth = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your gender.If you identfy yourself as a man enter 0 else enter 1: ");
            int gender = int.Parse(Console.ReadLine());

            if (birth < 2005 && gender == 0)
            {
                Console.WriteLine("Please have your military service check done.");
            }
            else {
                Console.WriteLine("You have no military obligations.");*/

            /*
            bool isAccsessValid = false;
            Console.WriteLine("Enter your access type: ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter your file ID: ");
            string file = Console.ReadLine();

            if (type == "0001" ||  type =="1120" || type == "2202")
            {
                if (file=="0001" || file=="1100" || file == "3521")
                {
                    isAccsessValid=true;
                }
            }
            else
            {
                isAccsessValid =false;
            }

            if (isAccsessValid)
            {
                Console.WriteLine("Access is valid.");
            }
            else
            {
                Console.WriteLine("Access is invalid.");
            }*/

            /*
            int defaultTotal = 50;
            string flavourType, toppingType;
            Console.WriteLine("Enter the code of your preffered flavour: ");
            string flavour = Console.ReadLine();
            Console.WriteLine("Enter the code of yoour prefered topping: ");
            string topping = Console.ReadLine();

            if (flavour == "01")
            {
                defaultTotal += 12;
            }
            if (topping == "010")
            {
                defaultTotal += 7;
            }
            if(topping == "110")
            {
                defaultTotal += 9;
            }

            if (flavour == "00")
            {
                flavourType = "Plane";
            }
            else
                flavourType = "Vanilla";

            if (topping == "010")
            {
                toppingType = "Chocolate chips";
            }
            else if (topping == "110")
            {
                toppingType = "Strawberry slices";
            }
            else
                toppingType = "None";

            Console.WriteLine("Preffered flavour {0}", flavourType);
            Console.WriteLine("Preffered topping {0}",toppingType);
            Console.WriteLine("Your order costs: {0}",defaultTotal);


            int car1, car2,area,a1=0,a2=0;
            Console.WriteLine("Enter the initial velocity of car 1: ");
            car1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the initial velocity of car 2: ");
            car2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rice area: ");
            area = int.Parse(Console.ReadLine());
            switch (area)
            {
                case 1:
                    a1 = 15;
                    a2 = 10;
                    break;
                case 2:
                    a1 = 10;
                    a2 = 12;
                    break;
                case 3:
                    a1 = 17;
                    a2 = 20;
                    break;
            }

            int vel1 = car1 + (a1 *10);
            int vel2 = car2 + (a2 * 10);
            Console.WriteLine("Velocity of the first car is {0}",vel1);
            Console.WriteLine("Velocity of the second car is {0}", vel2);
            Console.WriteLine(vel1 > vel2 ? "The first car won the rice" : "The second car won the rice.");



            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Are you student? (yes or no):");
            string student = Console.ReadLine();
            Console.WriteLine("What is your credit rate? (excellent or fair)");
            string creditRate = Console.ReadLine();


            if (age <= 30 && student == "yes")
            {
                Console.WriteLine("The customer has a HIGH chance to buy a computer");
            }
            else if (age > 30 && age <= 40)
            {
                Console.WriteLine("The customer has a HIGH chance to buy a computer");
            }
            else if (age > 40 && creditRate == "fair")
            {
                Console.WriteLine("The customer has a HIGH chance to buy a computer");
            }
            else
            {
                Console.WriteLine("The customer has a LOW chance to buy a computer");
            }*/
        }
    }
//}
