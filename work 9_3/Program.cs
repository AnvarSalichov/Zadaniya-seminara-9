// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное целое число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное целое число n");
int n = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine(recursion(m,n));

int FunctionAkkerman(int m, int n)
{
    if (m == 0)                       // Первое условие
    {
        return n + 1;
    } 
    else if ((m > 0) && (n == 0))      // Второе условие
    {
        return FunctionAkkerman(m - 1, 1);
    } 
    else     //  if (m > 0 && n > 0 )   // Третье условие
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
}
Console.WriteLine($"Функция Аккермана по ({m},{n}) равна {FunctionAkkerman(m, n)}");
