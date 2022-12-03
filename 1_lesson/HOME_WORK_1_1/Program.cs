//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("enter number 1");
string num1 = Console.ReadLine();
Console.WriteLine("enter number 2");
string num2 = Console.ReadLine();
Console.WriteLine("enter number 3");
string num3 = Console.ReadLine();

int a = int.Parse(num1);
int b = int.Parse(num2);
int c = int.Parse(num3);
int max;

if (a>b) 
{
    max=a;
} 

else 
{
    max=b;
}
   if (max>c)
   {
    Console.WriteLine (max);
   }
   else 
   {
    max=c;
    Console.WriteLine (max);
   }

