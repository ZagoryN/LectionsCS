﻿/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

Console.Write("Введите число A: ");  
/*int N = Convert.ToInt32(Console.ReadLine()); // вводим число A
int result = 0;
while (N > 0)
{
    N = N/10;
    result++;
}
Console.Write($"В этом числе {result} цифры");*/

//второе решение
/*string? A = Console.ReadLine();

Console.WriteLine(A.Length);*/

//третье решение с TryParse
Console.WriteLine(int.TryParse(Console.ReadLine(), out int a)); //проверка на число
Console.WriteLine(a);