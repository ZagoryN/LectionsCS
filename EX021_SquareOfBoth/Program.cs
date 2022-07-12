//Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго, или второе является квадратом первого
//a = 25, b = 5 -> да
//a = -4, b = 16 -> да
//a = 5, b = 25 -> да
//a = 2 b = 9 -> нет
Console.Write("Введите число a: ");  
int a = Convert.ToInt32(Console.ReadLine()); // вводим число a
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine()); // вводим число b
if (a == b*b || b == a*a)  // условие
{
    Console.WriteLine("да");  // ответ
}
else
{
    Console.WriteLine("нет"); //
}


