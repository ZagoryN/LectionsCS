//Задача 32: Напишите программу замены элементов массива: 
//положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

//int[] array = new int[6];

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

int[] array = FillArrayWithRandom(6, -8, 8);
Console.WriteLine("[" + string.Join(", ", array) + "]");

for (int i = 0; i < array.Length; i++)
{   
    array[i]=array[i] * (-1);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");