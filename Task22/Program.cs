// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

SquareNum(num);

void SquareNum(int number)
{
    int index = 1;
    while (index <= number)
    {
        Console.WriteLine($"{index} -> {index * index}");
        index++;
    }
}
