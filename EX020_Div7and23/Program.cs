//Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.Write("Введите число: ");  
int a = Convert.ToInt32(Console.ReadLine()); // вводим число a


int ost7 = a % 7;
int ost23 = a % 23;

if (ost7 == 0 && ost23 == 0)
{
    Console.WriteLine("Кратно 7 и 23");
}
    else
    {
        Console.WriteLine("Некратно");
    }