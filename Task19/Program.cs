// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Введите натуральное пятизначное число: ");
}
CheckPalindrom(number);
int CheckPalindrom(int num1)
{
    int n1 = 0;
    while (num1 > 0)
    {
        n1 = n1 * 10 + num1 % 10;
        num1 = num1 / 10;
    }
    return n1;
}
int number1 = CheckPalindrom(number);
string result =
    number1 == number ? $"Число {number} -> палиндром" : $"Число {number} -> не палиндром";
Console.WriteLine(result);


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int n1 = number;
// int n2 = 0;
// int num = 0;

// while(number > 0)
// {
//     num = number % 10;
//     n2 = n2 * 10 + num;
//     number = number / 10;
// }

// if(n1 == n2) Console.Write(" -> palindrom");

// else Console.Write(" -> not palindrom");