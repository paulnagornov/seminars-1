// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] NewArray(int size)
{
    int[] array = new int[size];
    Random num = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num.Next(0, 100);
    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
    Console.WriteLine("]");
}
int[] arr = NewArray(8);
PrintArray(arr);
