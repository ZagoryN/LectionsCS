﻿// пишем метод (функцию) нахождения максимального числа
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 10;
int b1 = 12;
int c1 = 15;
int a2 = 25;
int b2 = 26;
int c2 = 64;
int a3 = 52;
int b3 = 34;
int c3 = 157;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);
int max = Max(      // функция с аргументами-функциями, можно в 1 строку
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);
