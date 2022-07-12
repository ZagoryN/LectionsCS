void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++; //index = index + 1;
    }

}

void PrintArray(int[] col) //будем печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //решаем задачу из EX015
{
    int count = collection.Length;
    int index = 0;
    // int position = 0; //было первоначально
    int position = -1; //добавили на случай, если нет эл.find в массиве

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай массив, в котором будет 10 элементов
// по умолчанию все будут 0. Чтобы этого не было пишем void FillArray

FillArray(array);  //используем написанные методы
array[4]=4; //искуственно добавили, чтобы проверить провильность вывода
array[6]=4; //искуственно добавили, чтобы проверить провильность вывода

PrintArray(array);
Console.WriteLine(); //выводим пустую строку, чтобы отделить эл.массива

int pos = IndexOf(array, 444); //ПРОБЛЕМА: если find = 444, pos всегда будет 0
Console.WriteLine(pos);