// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.Write($"Четные числа от 1 до {num} : ");

while (count <= num)
{
    if (count % 2 == 0)
    {
        Console.Write($" {count} ");
    }
    count++;
}



















// int i = 1;
// bool not = true;
// Console.WriteLine("Введите натуральное число: ");
// number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Четные числа от 1 до " + number);
// while (i <= number)
// {
//     if (i % 2 != 1)
//     {
//         Console.Write(i + ",");
//         not = false;
//     }
//     i++;
// }
// if (not)
// {
//     Console.WriteLine("Нет четных чисел!");
// }

// {
//     break;
//     default;
//     begin = false;
//     break;
// }
