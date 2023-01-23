//  Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int number = int.Parse(Console.ReadLine());
int powNumbers = PowNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {powNumbers}");

int PowNumbers(int num) //num = number
{
    int pow = 1;
    for (int i = 1; i <= num; i++)
    {
        pow = pow * i;
    }
    return pow;
}

// Console.WriteLine("Insert number");
// bool IsEven(int value)
// {
//     return value % 2 == 0;
// }

// using System.Linq;
// var a = 12;
// // Console.WriteLine(a.GetType());
// var data = new int[] {1, 2, 3, 4};
//          .Where(e => e > 0)
//          .Select(e => new { q = e, w = e + 1 });
// Console.WriteLine(data.GetType().Name);            