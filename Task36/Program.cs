// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write(array[i] + ",");
        else
            Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int SumOddElements(int[] array)
{
    int sum = array[1];
    for (int i = 3; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
int arraySize = 5,
    arrayMinValue = -50,
    arrayMaxValue = 50;
int[] array = CreateArrayRndInt(arraySize, arrayMinValue, arrayMaxValue);
PrintArray(array);
int sumOddElements = SumOddElements(array);
Console.WriteLine($"Сумма элементов нечетных позиций массива = {sumOddElements}");
