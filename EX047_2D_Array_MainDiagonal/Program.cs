// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Попробуйте найти сумму элементов главной диагонали в одном цикле

Console.Write("Введите число строк m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n: ");  
int n = Convert.ToInt32(Console.ReadLine());


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

int[,] Matrix = FillMatrixRandomNumbers(m,n);
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

int sum = 0;
for (int i = 0; i < Matrix.GetLength(0); i++)
{
    sum = sum + Matrix[i,i];
}

Console.WriteLine(sum);

