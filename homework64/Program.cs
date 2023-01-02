// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N
// до 1. Выполнить с помощью рекурсии.
using System;
using static System.Console;

Clear();

Write("n-");
int n = int.Parse(ReadLine());
print(n);

void print(int end)
{
    if (end >= 1)
    {
        Write($"{end} ");
        print(end - 1);
    }
}