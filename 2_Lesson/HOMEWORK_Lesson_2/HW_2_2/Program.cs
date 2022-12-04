// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет. 

string Num (int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"{num} -> {num % 10}";
    return "The number is not three-digit!";
}
Console.WriteLine(Num(int.Parse(Console.ReadLine())));