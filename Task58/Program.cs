// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = rnd.Next(min, max + 1); 
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 5},");
            else
                Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("]");
    }
}

int[,] ProductMatrix(int[,] array1, int[,] array2)
{
    int temp = 0;
    int rowSize = array1.GetLength(0);
    int columnSize = array2.GetLength(1);
    int[,] newMatrix = new int[rowSize, columnSize];
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                temp += array1[i, k] * array2[k, j];
            }
            newMatrix[i, j] += temp;
            temp = 0;
        }
    }
    return newMatrix;
}

int[,] rndMatrix1 = CreateMatrixRndInt(2, 2, 1, 9);
Console.WriteLine("Матрица 1:");
PrintMatrix(rndMatrix1);
Console.WriteLine();
int[,] rndMatrix2 = CreateMatrixRndInt(2, 2, 1, 9);
Console.WriteLine("Матрица 2:");
PrintMatrix(rndMatrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц 1 и 2:");
int[,] productMatrix = ProductMatrix(rndMatrix1, rndMatrix2);
PrintMatrix(productMatrix);

