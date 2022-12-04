// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным. 

void Weekend(int num)
{
    string answer = "no";
    if (num == 7 || num == 6) answer = "yes";
    Console.WriteLine($"{num} -> {answer}");
}

Weekend(int.Parse(Console.ReadLine()));