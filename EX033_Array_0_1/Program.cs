//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
/*void FillArray(int[] collection)
{
    int length = 8 ;//collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,2);
        index++; //index = index + 1;
    }

}

void PrintArray(int[] col) //будем печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);
*/

int[] arr = new int[8];
Random rand=new Random();
for (int i = 0; i<arr.Length; i++)
{
    arr[i] = new Random().Next(0,2);
   // Console.Write(rand);
}

//int[] arr = (1,2);
Console.WriteLine(string.Join(", ", arr));
