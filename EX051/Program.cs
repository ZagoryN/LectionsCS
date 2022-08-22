//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.WriteLine("Введите число строк m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n: ");  
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixRandomNumbers(m,n);
PrintMatrix(matrix);
int[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = 0, int rightRange = 9)
// leftRange = 0 и rightRange = 9  - значения по умолчанию
{
    int[,] matr = new int[rows,columns];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rand.Next(leftRange, rightRange+1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matrixx)
{
    for (int i = 0; i < matrixx.GetLength(0); i++)
    {
        for (int j = 0; j < matrixx.GetLength(1); j++)
        {
            Console.Write(matrixx[i,j]+ " ");
        }
        Console.WriteLine();
    }
}



int ElementCount(int element, int [,] matrix)
{
    int count = 0;
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            if (element == matrix[i,j])
            {
                count++;
            }
        }
    }
    return count;
}

int minElement = 0;
int maxElement = 10;

for (int i =minElement; i < maxElement; i++)
{
    Console.WriteLine($"{i} встречается количество раз: {ElementCount(i, matrix)}");
}

// int temp = new Random().Next(0, 10);
//         arr[i, j] = temp;
//         arrN[temp]++;
