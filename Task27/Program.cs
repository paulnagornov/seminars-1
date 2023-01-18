// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int addOfDig = AddDigits(number);


int AddDigits(int a)

{
    int s = 0;
    for(int i = 0; i <=a ; i++)
    {
        a >= 1;
        s = s + a % 10;
        a = a / 10;
    }
    return s;
}
Console.WriteLine($"Сумма цифр числа {number} -> {addOfDig}");



