// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23.

void Number(int num)
{       
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"{num} -> multiple");
    }
    else
    {
        Console.WriteLine($"{num} -> not multiple");        
    }    
}

Number(14);
Number(46);
Number(161);

