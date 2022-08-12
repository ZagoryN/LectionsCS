//Задача 45: Напишите программу, которая будет создавать копию заданного массива 
//с помощью поэлементного копирования.

Console.WriteLine("Задайте длину массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArrayWithRandom(n, 0, 10);

Console.WriteLine($"Исходный массив [{string.Join(", ", arr)}]");

int[] FillArrayWithRandom (int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i=0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange+1);
    }
    return arr;
}

int[] CopyArray(int[] array)
{
    int[] copiedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copiedArray[i] = array[i];
    }
    return copiedArray;
}

int[] copiedArr = CopyArray(arr);

Console.WriteLine($"Скопированный массив [{string.Join(", ", copiedArr)}]");