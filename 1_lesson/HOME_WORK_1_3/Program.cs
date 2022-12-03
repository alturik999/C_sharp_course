// Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter number");
string Num = Console.ReadLine();
int N = int.Parse(Num);
int a = 2;

while (a <= N)
{
    Console.Write($"{a} ");
    a += 2;
}