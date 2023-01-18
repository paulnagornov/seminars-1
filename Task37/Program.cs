// Найдите произведение пар чисел в одномерном массиве. Парой считаем
// первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве (1 2 3 4 5) - 5 8 3


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
int[] ReturnNewArray(int[] array)
{
    int size = array.Length % 2 != 0 ? array.Length / 2 + 1 : array.Length / 2;
    int[] retArray = new int[size];
    for (int i = 0; i < retArray.Length; i++)
    {
        if (i == retArray.Length - 1 && array.Length % 2 == 1)
        {
            retArray[i] = array[i];
        }
        else
        {
            retArray[i] = array[i] * array[array.Length - i - 1];
        }
    }
    return retArray;
}

int size = 5,
    min = 0,
    max = 10;
int[] newArray = CreateArrayRndInt(size, min, max);
string strArray = ArrayToString(newArray);
int[] newArray2 = ReturnNewArray(newArray);
string strArray2 = ArrayToString(newArray2);
Console.WriteLine($"{strArray} -> {strArray2}");
