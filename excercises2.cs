using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__
{
    internal class uygulama3
    {
        //static void Main(string[] args)
        //{
            /*
            //Armstrong sayı bulma
            Console.Write("Please enter a 3-digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int firstDigit = num / 100;
            int secondDigit = (num / 10)%10;
            int thirdDigit = num % 10;

            string rule = (firstDigit*firstDigit*firstDigit)+(secondDigit*secondDigit*secondDigit)+(thirdDigit*thirdDigit*thirdDigit)==num?"an Armstrong number":"not an Armstrong number";
            Console.WriteLine("This number is "+rule);*/

            /*
            //Division by 11
            int num,a,b,c,d,e;
            Console.Write("Please enter a 5-digit number: ");
            num = Convert.ToInt32(Console.ReadLine());

            a = num / 10000;
            b = (num / 1000) % 10;
            c = (num / 100) % 10;
            d = (num / 10) %10;
            e = num % 10;

            bool rule = (a+c+e)-(b+d)==0|| ((a + c + e) - (b + d))%11==0;
            Console.WriteLine(rule==true?"This number is divisible by 11.":"This number is not divisible by 11.");*/


            /*
            Console.WriteLine("WELCOME TO THE ATU LİBRARY");
            Console.WriteLine("Please enter your book's name: ");
            string bookName = Console.ReadLine();
            Console.WriteLine("Please enter your book's category: ");
            string category = Console.ReadLine();
            string categoryName = category == "Fiction" ? "F" : category == "Horror" ? "H" : category == "Science" ? "S" : "P";
            Console.WriteLine("Your book {0} is on the shelf {1}",bookName,categoryName);
            Console.WriteLine("Please enter your ID to complete to borrowing operation : ");
            long ID  = long.Parse(Console.ReadLine());
            Console.WriteLine(ID.ToString().Length==8 && ID.ToString()[0]=='2' && ID.ToString()[1] == '2'?"You are book is borrowed.":"You are not allowed to borrow a book.");*/


            /*
            int total = 0;
            Console.WriteLine("Do you have a fever?");
            string fever = Console.ReadLine();
            total = fever == "yes" ? total+= 1 :total;
            Console.WriteLine("Are you sneezing?");
            string sneez = Console.ReadLine();
            total = sneez == "yes" ? total += 1 : total;
            Console.WriteLine("Does your back or arm hurt?");
            string backOrArm  = Console.ReadLine();
            total = backOrArm == "yes" ? total += 3 : total;
            Console.WriteLine("Does your chest hurt?");
            string chest  = Console.ReadLine();
            total = chest == "yes" ? total += 5 : total;
            Console.WriteLine("Do you have nausea?");
            string nausea = Console.ReadLine();
            total = nausea == "yes" ? total += 1 : total;

            Console.WriteLine(total>=6? "You should go to the nearest hospital. You might have a heart attack.": "You are just having a flu, have a cup of hot tea.");*/


            /*
            int amount = 500;
            Console.WriteLine("Please enter the amount for withdraw: ");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(amount > withdrawAmount ? "Amount in bank account: {0}" :
                withdrawAmount - amount < 500 ? "Amount in bank account: -{1}\nYou are charged with: {2}" :
                "You can withdraw 1000$ at most!\nAmount in bank account: 0$\nYou are charged with: {3}",
                amount - withdrawAmount, withdrawAmount - amount, (withdrawAmount - amount) * 1.7, 500 * 1.7);*/
        }
    }
//}
