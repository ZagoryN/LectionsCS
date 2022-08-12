//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

// как ввести числа в массив через пробел
/*string input = Console.ReadLine();  
int[] numbers = input.Split().Select(x => Convert.ToInt32(x)).ToArray();
Console.WriteLine($"[{string.Join(", ", numbers)}]");*/

//решение со строками
/*
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

string str = string.Empty;
while (numA > 0)
{
    str = numA % 2 + str;
    numA /=2;
}

Console.WriteLine(str);
*/

//решение с помощью рекурсии
/*
Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

PrintBinaryNumber(number);

void PrintBinaryNumber(int number) //печатает остатки в нужном порядке
{
    if (number == 0)
    {
        return;
    }
    else
    {
        PrintBinaryNumber(number /2);  //пока выполняется данная команда, пока проиходит деление, 
                                        // следующая команда (ConsoleWrite) выполняться не будет!
        Console.Write(number % 2); // печатается последний результат остатка от деления
    }
}
*/
//решение с помощью логарифма

Console.Clear();
Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[] binNum = new int [Convert.ToInt32(Math.Log2(n1))+1];
int i = binNum.Length-1; 
while (i >= 0)
{
    binNum[i] = n1 % 2;
    n1 /= 2;
    i--;
}

Console.WriteLine($"[{string.Join(", ",binNum)}]");
