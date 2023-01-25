// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {number} числа(чисел) через запятую: ");
string str = Console.ReadLine();
string[] strInp = str.Split(",");

while (strInp.Length != number)
{
    Console.Write($"Введено неверное количество чисел = {number}. Введите заново: ");
    str = Console.ReadLine();
    strInp = str.Split(",");
}

int[] InputDigits(string[] strInput)
{
    int[] inputDigits = new int[strInput.Length];
    for (int i = 0; i < strInput.Length; i++)
    {
        inputDigits[i] = Convert.ToInt32(strInput[i]);
    }
    return inputDigits;
}

int PlusNumbers(int[] array)
{
    int plusNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            plusNumbers++;
    }
    return plusNumbers;
}

int[] inpDigits = InputDigits(strInp);
int plusNumbers = PlusNumbers(inpDigits);
Console.WriteLine(str + $" -> {plusNumbers}");
