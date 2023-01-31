﻿// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int SquareNumbers(int numA, int numB)
{
    if(numB == 0) return 1;
    return numA * SquareNumbers(numA, numB - 1);
}
int num = SquareNumbers(numberA, numberB);
Console.WriteLine(num);