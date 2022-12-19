// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int number1 = new Random().Next(1, 100);
int number2 = new Random().Next(1, 10);
Console.WriteLine("Введите два числа");
int div = number1 % number2;
if (div == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine($"Первое число не кратно второму, остаток {div}");
}




// int DeleteSecond(int num)
// {
//     int firstDigit = num / 100;
//     int thirdDigit = num % 10;
//     return firstDigit * 10 + thirdDigit; 
// }
// Console.WriteLine(DeleteSecond(number));



Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

bool DivCheck(int number1, int number2)
{
    return number1 % number2 == 0;
}

if (DivCheck(userNumber, userNumber2))
{
    Console.WriteLine($"{userNumber}, {userNumber2} -> кратно");
}
else
{
    Console.WriteLine($"{userNumber}, {userNumber2} -> не кратно, остаток " + (userNumber % userNumber2));
}
