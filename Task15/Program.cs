// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число от 1 до 7");
int dayNumber = Convert.ToInt32(Console.ReadLine());

CheckDay(dayNumber);

void CheckDay(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else if (dayNum < 1 || dayNum > 7)
    {
        Console.WriteLine("Ошибка ввода");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
