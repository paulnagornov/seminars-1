// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

string DoubleToString(double[] array)
{
    string result = "  ";
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
        result += (i < array.Length - 1) ? "  " : "";
    }
    return result;
}

double[] ArithAverageOfEveryColumns(int[,] array)
{
    double[] array1 = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            array1[j] += array[i, j];
        array1[j] /= array.GetLength(0);
        array1[j] = Math.Round(array1[j], 1);
    }
    return array1;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("]");
    }
}

Console.Clear();
int[,] rndMatrix = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(rndMatrix);
Console.WriteLine();
double[] arithmeticAverage = ArithAverageOfEveryColumns(rndMatrix);
string average = "Arithmetic average of every columns:";
average += DoubleToString(arithmeticAverage);
Console.WriteLine(average);
