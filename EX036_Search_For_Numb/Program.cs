//Задача 33: Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да


int[] FillArrayWithRandom (int size, int leftRange, int rightRange) //наполняем массив
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i=0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange+1);
    }
    return arr;
}

int[] array = FillArrayWithRandom(6, -8, 8); // вызываем метод
Console.WriteLine("[" + string.Join(", ", array) + "]");

//int find = new Random().Next(1,8);
//Console.WriteLine(find);

int FindElement(int[] arr, int find)
{
    int count = arr.Length;
    int index = 0;
    int position = -1;
    Console.WriteLine($"Искомый элемент {find}");
    while (index < count)
    {
        if (arr[index] == find)
        {
            position = index;
        }
        index++;
    }
    if (position < 0)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
    return position;
}

FindElement(array, 9);