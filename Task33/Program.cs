// Задача 33. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4, массив (6 7 19 345 3) - нет
// 3, массив (6 7 19 345 3) - да


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
bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return true;
    }
    return false;
}
int[] arr = CreateArrayRndInt(5, 0, 10);
PrintArray(arr);
Console.WriteLine("Insert searching number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNumber(arr, num) ? "yes" : "no");
