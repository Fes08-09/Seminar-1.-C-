// Задача 1. Написать программу по проверке является первое число квадратом второго

using System;
using static System.Console; // если будет видеть неизвестную команду, он будет ее искать в класс Console и везде можем убрать надпись Console

Clear();
WriteLine("Введите число 1");
int number1 = Convert.ToInt32(ReadLine());
WriteLine("Введите число 2");
int number2 = Convert.ToInt32(ReadLine());

int SqrNumber2 = Convert.ToInt32(Math.Pow(number2, 2));

if(Convert.ToBoolean(number1 == SqrNumber2))
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}