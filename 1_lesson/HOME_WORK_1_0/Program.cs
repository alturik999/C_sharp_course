// Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("enter number 1");
string N1 = Console.ReadLine();
int a = int.Parse(N1);

Console.WriteLine("enter number 2");
string N2 = Console.ReadLine();
int b = int.Parse(N2);

if (a > b)
{
    Console.WriteLine($"The number {a} is greater than {b}");
}

else if (a == b)
{
    Console.Write($"The number {a} is equal to the number {b}");

}
else
{
    Console.Write($"The number {b} is greater than {a}");
}