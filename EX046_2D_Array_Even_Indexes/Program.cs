// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.Write("Введите число строк m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n: ");  
int n = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = FillMatrixRandomNumbers(m,n);
int[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = 0, int rightRange = 10)
// leftRange = 0 и rightRange = 10  - значения по умолчанию
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
PrintMatrix(Matrix);

for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
           if (i % 2 == 0 && j % 2 == 0)
           {
            Matrix[i,j] = Matrix[i,j] * Matrix[i,j];
           }
        }
    }

PrintMatrix(Matrix);

