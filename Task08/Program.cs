// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


int i = 1;
bool not = true;
Console.WriteLine("Введите натуральное число: ");
number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до " + number);
while (i <= number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ",");
        not = false;
    }
    i++;
}
if (not)
{
    Console.WriteLine("Нет четных чисел!");
}

{
    break;
    default;
    begin = false;
    break;
}








// Console.Write($"{N} ---> ");
// int i = 2;
// while (i <= N)
// {
//     Console.Write(" " + i); i = i + 2;
//     if (i <= N) Console.Write(",");
// }
