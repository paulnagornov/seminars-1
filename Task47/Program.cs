﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    return matrix;
}

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
//             else Console.Write($"{matrix[i, j], 5} ");
//         }
//         Console.WriteLine("]");
//     }
// }

string ArrayDoubleToString(double[,] array)
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += "[";

        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + $" {array[i, j],4}";
            result = j < (array.GetLength(1) - 1) ? result + " " : result;   
        }

        result += "]\n";
    }
    return result;
}


int matrixRow = 3,
    matrixColumns = 4,
    matrixMin = -50,
    matrixMax = 50;

double[,] rndMatrix = CreateMatrixRndDouble(matrixRow, matrixColumns, matrixMin, matrixMax);

string matrixString = ArrayDoubleToString(rndMatrix);
Console.Clear();
Console.WriteLine(matrixString);