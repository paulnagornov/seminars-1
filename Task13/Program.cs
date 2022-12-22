﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && <= 999)
{
    Console.WriteLine($"Последняя цифра числа {number % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

