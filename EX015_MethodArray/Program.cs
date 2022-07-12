int[] array = {11, 12, 31, 4, 15, 18, 16, 17, 18, 91};

int n = array.Length; // возвращает длину массива
int find = 18;

int index =0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //поскольку в массиве 2 искомых элемента (18), необходимо
              // закончить после нахождения первого, вывод индекса
              // если уберем break; покажет оба индекса элемента
    }
    //index= index + 1
    index++;
}