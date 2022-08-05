//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = FillArrayWithRandomNumbers(6,1,8);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int newLength = array.Length/2 + (array.Length %2);

int[] newArray = new int [newLength];

for (int i = 0; i < array.Length/2; i++)
{
    newArray[i]= array[i] * array[array.Length-1-i];
}
if (array.Length % 2 > 0)
    {
        newArray[newArray.Length-1] = array[array.Length/2];
    }

Console.WriteLine('[' + string.Join(", ", newArray) + ']');
