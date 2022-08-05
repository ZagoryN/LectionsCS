//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
int[] array = new int[6];
Random rand = new Random();

int sumPos = 0;
int sumNeg = 0;

for (int i=0; i < array.Length; i++)
{
    array[i] = rand.Next(-9,10);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

for (int i=0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPos += array[i]; // накопить положительную сумму
    }

        if (array[i] < 0)
    {
        sumNeg += array[i]; // накопить положительную сумму
    }
}
Console.Write($"Сумма положительных элементов = {sumPos}, Cумма отрицательных чисел = {sumNeg}");