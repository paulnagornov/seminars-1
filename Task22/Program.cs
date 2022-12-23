// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


// Console.WriteLine("Введите натуральное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// SquareNum(num);

// void SquareNum(int number)
// {
//     int index = 1;
//     while (index <= number)
//     {
//         Console.WriteLine($"{index} -> {index * index}");
//         index++;
//     }
// }

// С проверкой на отрицательное.


void Numb(int n1)
{
    int counter = 1;
    while (counter <= n1)
    {
        Console.WriteLine($"{counter, 3} {counter * counter, 3}");
        counter++;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 1)
{
    Console.WriteLine("Введите положительное, целое число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
Numb(number);
