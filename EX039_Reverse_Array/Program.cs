//Задача 39: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]


//немного теории 
/*//string text = null; // null - пустая ссылка
string text = string.Empty; // empty - это просто пустая строка
int numberParse = int.Parse(text); //exeption - вылетит программа
int numberConvert = Convert.ToInt32(text); //numberConvert = 0 */
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

int[] ReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length - 1 - i];
    }
    return reversedArray;
}

int[] reversedArr = ReverseArray(arr);

Console.WriteLine($"Перевернутый массив [{string.Join(", ", reversedArr)}]");