/*Задача 1: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
Пример
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
M = 8; N = 4 -> "8, 7, 6, 5, 4"*/
using System.Reflection.Emit;

string PrintMNNumbers(int M, int N)
{
    if (M > N)
    {
        if (M == N) return M.ToString();
        return M + ", " + PrintMNNumbers(M - 1, N);
    }
    else
    {
        if (M == N) return M.ToString();
        return M + ", " + PrintMNNumbers(M + 1, N);
    }
}

int M = 0, N = 4;
Console.WriteLine(PrintMNNumbers(M, N));