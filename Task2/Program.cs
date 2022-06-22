// Задача 3. Вводим номер дня недели в ответ должны увидеть название дня недели

using System;
using static System.Console; // если будет видеть неизвестную команду, он будет ее искать в класс Console и везде можем убрать надпись Console

Clear();
WriteLine("Введите день недели (число)");
int number = Convert.ToInt32(ReadLine());

if(number == 1)
{
    WriteLine("Понедельник");
}
if(number == 2)
{
    WriteLine("Вторник");
}
if(number == 3)
{
    WriteLine("Среда");
}
if(number == 4)
{
    WriteLine("Четверг");
}
if(number == 5)
{
    WriteLine("Пятница");
}
if(number == 6)
{
    WriteLine("Суббота");
}
if(number == 7)
{
    WriteLine("Воскресение");
}