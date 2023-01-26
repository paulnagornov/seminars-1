// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrixRndIntArray(int rowSize, int colSize, int minValue, int maxValue) 
{
    int[,] resArray = new int[rowSize, colSize];
    Random rnd = new Random();

    for (int i = 0; i < resArray.GetLength(0); i++)
        for (int j = 0; j < resArray.GetLength(1); j++)
            resArray[i, j] = rnd.Next(minValue, maxValue + 1);

    return resArray;
}


string ArrayToString(int[,] array)//Метод преобразования массива в строку
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += "[";

        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + $" {array[i, j],3}";
            result = j < (array.GetLength(1) - 1) ? result + "," : result;    
        }

        result += "]\n";
    }
    return result;
}


void ReplaceLastAndFirstRow(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }

}


//Параметры для генерации двумерного массива типа int.
int matrixRowSize = 5,
    matrixColSize = 4,
    matrixMinValue = -99,
    matrixMaxValue = 99;

int[,] rndMatrixInt = CreateMatrixRndIntArray(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);

Console.WriteLine(ArrayToString(rndMatrixInt));

ReplaceLastAndFirstRow(rndMatrixInt);
Console.WriteLine(ArrayToString(rndMatrixInt));