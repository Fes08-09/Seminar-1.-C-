﻿// Задача 4. На целочисленное деление. Напишите программу, которая принимает на вход 3-х значное число и на выходе показывает последнюю цифру этого числа

using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int N = Convert.ToInt32(Console.ReadLine());

if((Math.Abs(N) < 100) || (Math.Abs(N) > 999)) // данная функция Math.Abs(N) позволяет взять модуль числа => мы можем работать и с отрицательными числами
{
    Console.WriteLine("Неверное число!!!");
    return;
}
Console.WriteLine(N%10); // данная %  позволяет вычислять остаток по модулю. Это целочисленное деление