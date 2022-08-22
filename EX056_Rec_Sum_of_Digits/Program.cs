//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

Console.Write("Введите число для поиска суммы его цифр");
int inputNumber = Convert.ToInt32(Console.ReadLine());

int res = GetSumOfDigits(inputNumber);
Console.WriteLine(res);

int GetSumOfDigits(int number)
{
    if (number <= 0) return 0;
    int digit = number % 10;
    return digit + GetSumOfDigits(number / 10);
}
