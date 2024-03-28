﻿/*Задача 2: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/
int Ackermann(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Ackermann(n - 1, 1);
    return Ackermann(n - 1, Ackermann(n, m - 1));
}
int m = 2, n = 3;
Console.WriteLine(" " + Ackermann(n, m));


