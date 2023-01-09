// 2. Задайте значения M и N. Напишите программу, которая найдёт сумму
//    натуральных элементов в промежутке от M до N с помощью рекурсии.

int AllNumersSum(int M, int N)
{
    if (M > N) return 0;    
    return AllNumersSum(M, N - 1) + N;
}

Console.WriteLine(AllNumersSum(1, 15));
Console.WriteLine(AllNumersSum(4, 8));
