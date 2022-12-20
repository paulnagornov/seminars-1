// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите число:");
int userNum1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int userNum2 = Convert.ToInt32(Console.ReadLine());

bool DivCheck(int num1, int num2)
{
    return num1 % num2 == 0;
}

if (DivCheck(userNum1, userNum2))
{
    Console.WriteLine($"{userNum1}, {userNum2} -> кратно");
}
else
{
    Console.WriteLine($"{userNum1}, {userNum2} -> не кратно, остаток " + (userNum1 % userNum2));
}
