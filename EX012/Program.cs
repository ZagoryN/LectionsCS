﻿//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.Write("Введите число от 100 до 999: ");  // приглашение ко вводу
double a = Convert.ToInt32(Console.ReadLine()); // вводим число N

// double c = a/10;
// double b = a/10 - Convert.ToInt32(c);
// double d = b*(-10);
Console.Write(a % 10);