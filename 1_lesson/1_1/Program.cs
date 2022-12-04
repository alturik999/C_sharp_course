// Напишите программу, которая на вход
//принимает два числа и проверяет, является ли первое
//число квадратом второго.

Console.WriteLine ("Enter first number");
int num1 = int.Parse (Console.ReadLine());

Console.WriteLine ("Enter second number");
int num2 = int.Parse (Console.ReadLine());

if (num2 == num1*num1)
{
    Console.WriteLine ("Yes");
}
else
    Console.WriteLine ("No");
