// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.

int Summ(int[,] arr)
{
    int sum = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(Summ(arr_1));

                

