Console.WriteLine("Введите первое целое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine($"Первое число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Первое число {a} не является квадратом числа {b}");
}