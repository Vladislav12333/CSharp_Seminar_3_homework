﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Таблица кубов чисел от 1 до " + n);

for (int i = 1; i <= n; i++)
{
    int cube = i * i * i;
    Console.WriteLine(i + " ^ 3 = " + cube);
}