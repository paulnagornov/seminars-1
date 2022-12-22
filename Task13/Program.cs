// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет. Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine($"В числе {number} третьей цифры нет");
}
else
{
    int thirdDigit = ThirdDigit(number);
    Console.Write($"Третья цифра числа: {number} -> {thirdDigit}");
}

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
    return result;
}
