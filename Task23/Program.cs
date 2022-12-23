// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 1)
{
    Console.WriteLine("Введите натуральное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
NumCube(num);

void NumCube(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 3} -> {count * count * count, 3}");
        count++;
    }
}