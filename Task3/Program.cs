// Задача 3. Напишите программу, котора на вход принимает одно число, а на выходе показывает все целые числа в промежутке от -N до N

using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Введите цифру");
int N = Convert.ToInt32(ReadLine());
int count = N * -1;

while(count <= N)
{
    int numbers = count;
    Console.Write(numbers);
    Console.Write(", ");
    count++;
}