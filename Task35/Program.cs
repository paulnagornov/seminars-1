// Задайте одномерный массив из 123 случайных чисел. найдите количество
// элементов массива, значения которых лежат в отрезке (10,99)


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
string ArrayToString(int[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $"{array[i]}";
        result = i < (array.Length - 1) ? result = result + "," : result;
    }
    return result + "]";
}

int CountElements(int[] array, int fMin, int fMax)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= fMin && array[i] <= fMax)
            result++;
    }
    return result;
}

int size = 123,
    min = 0,
    max = 123,
    fMin = 10,
    fMax = 99;
int[] newArray = CreateArrayRndInt(size, min, max);
string strArray = ArrayToString(newArray);
int count = CountElements(newArray, fMin, fMax);
Console.WriteLine($"{strArray} -> {count}");
