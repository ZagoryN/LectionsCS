// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Введите номер четверти: ");  // приглашение ко вводу
int x = Convert.ToInt32(Console.ReadLine()); // вводим число X

if (x < 1 || x > 4) Console.Write("Такой четверти не существует");
else
{
    if (x == 1) Console.Write("x > 0, y > 0");
    if (x == 2) Console.Write("x < 0, y > 0");
    if (x == 3) Console.Write("x < 0, y < 0");
    if (x == 4) Console.Write("x > 0, y > 0");
}