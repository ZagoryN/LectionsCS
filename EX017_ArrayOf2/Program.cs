//Напишите, программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8
int number = new Random().Next(10,100);

Console.WriteLine($"Наше число = {number}");

int secondDigit = number % 10;  // переменная для посл.цифры
int firstDigit = number / 10;

Console.WriteLine($"первая цифра = {firstDigit}, вторая цифра = {secondDigit}");

if (firstDigit > secondDigit)
{
    Console.WriteLine($"первая цифра числа больше - это {firstDigit}");
}
else
{
    Console.WriteLine($"вторая цифра числа больше - это {secondDigit}");
}