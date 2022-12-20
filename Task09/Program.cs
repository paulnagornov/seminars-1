//9. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10-99 => {number}");

//при методе, эти две строки не нужны

// int firstDigit = number / 10;
// int secondDigit = number % 10;

//стандартное решение

// if (firstDigit > secondDigit)
// {
//      Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// }
// else
// {
//      Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");
// }

//с тернарным оператором

// Console.Write("Наибольшая цифра числа = ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

// метод


int maxDigit = MaxDigit(number);
Console.Write($"Наибольшая цифра числа = {maxDigit}");

int MaxDigit(int number);
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}
    

