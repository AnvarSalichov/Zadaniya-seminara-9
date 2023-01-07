// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int m = Convert.ToInt32(Console.ReadLine());

if (n <= 0 || m <= 0)                                
{
    Console.WriteLine("Введено отрицательное число или нуль, вводите целые положительные числа");
    return;
}

int SumNum (int m, int n)
{
    if (n==m)
    {
        return n;
    }
    else if (m>n)
    {
        return(m+SumNum(m-1,n));     
    }
    else
    {
        return(m+SumNum(m+1, n));      
    }
    
}

Console.WriteLine("N = "+n+"; M = "+m+"; -> " +(SumNum(m, n)));