// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();

Write("M-");
int m = int.Parse(ReadLine());
Write("N-");
int n = int.Parse(ReadLine());
int count = print(m, n);
WriteLine(count);

int print(int start, int end)
{
    if (start <= end)
    {
        return start + print(start + 1, end);
    }
    else
    {
        return 0;
    }
}