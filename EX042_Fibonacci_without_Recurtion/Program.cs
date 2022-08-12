//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n1 = 0;
Console.Write(n1 + " ");
int n2 = 1;
Console.Write(n2 + " ");

for (int i = 2; i < number; i++)
{
    int newNumber = n1 + n2;
    Console.Write(newNumber + " ");
    n1 = n2;
    n2 = newNumber;
}