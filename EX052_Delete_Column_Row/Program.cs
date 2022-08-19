﻿//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// Task52 Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] array = FillRandomDoubleArray();
PrintMatrix(array);
Console.WriteLine();
PrintMatrix(TrimArray(array));



int[,] TrimArray(int[,] matrix)
{
    int[,] trimArray = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int minI = 0;
    int minJ = 0;
    int min = matrix[minI, minJ];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minI = i;
                minJ = j;
            }
        }
    }

    for (int i = 0; i < trimArray.GetLength(0); i++)
    {
        for (int j = 0; j < trimArray.GetLength(1); j++)
        {

            if (i >= minI & j >= minJ)
            {
                trimArray[i, j] = matrix[i + 1, j + 1];
            }
            else if (i >= minI)
            {
                trimArray[i, j] = matrix[i + 1, j];
            }
            else if (j >= minJ)
            {
                trimArray[i, j] = matrix[i, j + 1];
            }
            else
            {
                trimArray[i, j] = matrix[i , j ];
            }
        }
    }
    return trimArray;
}

int[,] FillRandomDoubleArray(int lines = 3, int columns = 4, int leftRange = 0, int rethRange = 10)
{
    int[,] randomArray = new int[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = rand.Next(leftRange, rethRange + 1);
        }
    }
    return randomArray;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}







// может так?

// for (int i = minI; i < m - 1; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         arr[i, j] = arr[i + 1, j];
//     }
// }
// for (int j = minJ; j < n - 1; j++)
// {
//     for (int i = 0; i < n; i++)
//     {
//         arr[i, j] = arr[i, j + 1];
//     }
// }
