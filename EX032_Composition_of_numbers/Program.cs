/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

Console.Write("Введите число N: ");  
int N = Convert.ToInt32(Console.ReadLine()); // вводим число N
int comp = 1;
for (int i = 1; i <= N; i++)
    {
        comp = comp*i;
    }
Console.Write($"Произведение всех цифр от 1 до {N}: {comp}");
