using System;
using static System.Console; // если будет видеть неизвестную команду, он будет ее искать в класс Console и везде можем убрать надпись Console

Clear();
WriteLine("Введите число"); 
int number = Convert.ToInt32(ReadLine()); // чтобы конвертировать числа в строки можем исп: 
int number1 = int.Parse(ReadLine());

int sqrNumber = number * number;
int sqrNumber1 = Convert.ToInt32(Math.Pow(number1, 2)); // возводим в квадрат двумя способами

WriteLine(sqrNumber);