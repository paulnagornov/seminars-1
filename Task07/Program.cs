Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
    Console.WriteLine($"Последняя цифра числа {num % 10}");
}
else
{
    Console.WriteLine("Число не трехзначное!");
}