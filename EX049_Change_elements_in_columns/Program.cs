//Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и 
//последнюю строку массива.

Console.WriteLine("Введите число строк m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n: ");  
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixRandomNumbers(m,n);
PrintMatrix(matrix);
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


// void ChangeMatrixFirsttoEndString(int[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[Matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = matrix[0, j];
//         matrix[0, j] = temp;
//     }
// }

for (int i = 0; i < matrix.GetLength(1); i++)
{
    int number = matrix[0, i];
    matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
    matrix[matrix.GetLength(0) - 1, i] = number;
}
Console.WriteLine();
PrintMatrix(matrix);








