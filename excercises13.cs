// See https://aka.ms/new-console-template for more information
/*
int year = 2025;
Console.WriteLine("Year {0,10}",year);
Console.WriteLine("Year {0,-10}.", year);
Console.WriteLine("{0} {1,40}","Head of the","Software engineering department");
Console.WriteLine("{0:C}", 543.1453);
Console.WriteLine("{0:F3}",543.1456);
Console.WriteLine("{0:D10}", 74131);
Console.WriteLine("{0:P}", 0.78 );
Console.WriteLine("{0:P}", 78);
Console.WriteLine("--------------------------");
Console.WriteLine("{0:0.000}",25.1);
Console.WriteLine("{0:#.###}", 25.1);
Console.WriteLine("{0:#.###}", 25.15464);
Console.WriteLine("{0:####-##-##}", 20250926);
DateTime date = DateTime.Now;
Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}",date);
Console.WriteLine("{0:d.MM.yy}",date);*/

/*
Console.WriteLine("Please enter the 1st student's grade: ");
double grade1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the 2st student's grade: ");
double grade2 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the 3st student's grade: ");
double grade3 = double.Parse(Console.ReadLine());

double avg = (grade1 + grade2 + grade3) / 3;

Console.WriteLine("The avarage grade of the student is {0:#.##}",avg);*/

/*
Console.WriteLine("Enter x0: ");
int x0 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y0: ");
int y0 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y1: ");
int y1 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x0 - x1,2) + Math.Pow(y0 - y1,2));
Console.WriteLine("The total distance between two points is: {0:#.###}",distance);*/


/*
Console.WriteLine("Enter a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter c:");
int c = Convert.ToInt32(Console.ReadLine());

string triangle = a + b > c && a + c > b && b + c > a ? "satisfied" : "unsatisfied";
Console.WriteLine("The rule of triangle is "+triangle);*/

/*
int total_score = 0;
Console.WriteLine("Enter your registration status: ");
char r_type = char.Parse(Console.ReadLine());
Console.WriteLine("Enter your operation type: ");
char o_type = char.Parse(Console.ReadLine());
Console.WriteLine("Enter your registration status: ");
char t_type = char.Parse(Console.ReadLine());

total_score = r_type == 'o' ? 1 : 2;
total_score = o_type == 'b' ? total_score += 1 : o_type == 'd' ? total_score += 2 : total_score += 3;
total_score = t_type == 'l' ? total_score += 1 : t_type == 'b' ? total_score += 2 : total_score += 3;
string customer = total_score > 5 ? "accepted" : "denied";
Console.WriteLine("Your application has been "+customer);*/


using System.Diagnostics;

Console.WriteLine("Enter a 4-digit number to check wheter your number is polindrome: ");
int num = Convert.ToInt32(Console.ReadLine());

int dig1 = num / 1000;
int dig2 = (num /100)%10;
int dig3 = (num / 10) % 10;
int dig4 = num % 10;

string cond = dig1 == dig4 && dig2 == dig3 ? "polindrome" : "not polindrome";
Console.WriteLine("Your number is "+cond);