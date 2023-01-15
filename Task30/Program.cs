//  Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] arr = CreateArray(8);
PrintArray(arr);





// Console.WriteLine("Введите имя пользователя: ");
// string username = Console.ReadLine();
// if (username.ToLower() == "kirill")
// {
//     Console.WriteLine("Hi Mr. kirill");
// }
// else
// {
//     Console.Write("Hi, ");
//     Console.WriteLine(username);
// }
