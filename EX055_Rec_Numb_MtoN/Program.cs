//Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число М:");
int M = Convert.ToInt32(Console.ReadLine());

void PrintNumbersMtoN(int a, int b) //a<b
{
    if (a > b) return;
    Console.Write(a + " ");
    PrintNumbersMtoN(a + 1, b); 
}

void PrintNumbersNtoM(int a, int b) //a<b
{
    if (a > b) return;
    PrintNumbersNtoM(a + 1, b); 
    Console.Write(a + " ");
}

if (M < N)  PrintNumbersMtoN(M,N);
else    PrintNumbersNtoM(N, M);





