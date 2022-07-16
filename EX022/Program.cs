﻿// Задача 17. Напишите программу, которая приимает на вход координаты точки
// X и Y, причем X равно 0, Y не равно 0 и выдает номер четверти,
// в которой нахдится точка.
Console.Write("Введите число X: ");  // приглашение ко вводу
int x = Convert.ToInt32(Console.ReadLine()); // вводим число X
Console.Write("Введите число Y: ");  // приглашение ко вводу
int y = Convert.ToInt32(Console.ReadLine()); // вводим число Y

if (x == 0 || y == 0) Console.Write("X или Y равен 0. Невозможно определить четверть");
else
{
    if (x > 0 && y > 0) Console.Write("Точка находится в I четверти");
    if (x < 0 && y > 0) Console.Write("Точка находится в II четверти");
    if (x < 0 && y < 0) Console.Write("Точка находится в III четверти");
    if (x > 0 && y < 0) Console.Write("Точка находится в IV четверти");
}