//Задача 55: Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести 
//сообщение для пользователя.

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

int [,] newArray55 = new int[matrix.GetLength(1), matrix.GetLength(0)];

for (int i = 0; i < newArray55.GetLength(0); i++)
{
    for (int j = 0; j < newArray55.GetLength(1); j++)
    {
        newArray55[i,j]=matrix[j,i];
    }
}
Console.WriteLine();
PrintMatrix(newArray55);
