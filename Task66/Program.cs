// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumberInput(string text) 
{
    Console.Write(text);
    int numberInput = Convert.ToInt32(Console.ReadLine());
    return numberInput;
}

//Метод для подсчета всех целых чисел в промежутке от M до Н
(string text, int sum) SumIntegerNumbers(int n, int m, int s)
{
    (string text, int sum) result = (text: String.Empty, sum: 0);
    if (n == m)
    {
        result.text += $"{n} ";
        result.sum += n;
        return result;
    }
    result = SumIntegerNumbers(n - s, m, s);
    result.text = result.text + $"+ {n} ";
    result.sum = result.sum + n;
    return result;
}

int mUser = NumberInput("Введите число M:");
int nUser = NumberInput("Введите число N:");

int sign = Math.Sign(nUser - mUser);
Console.WriteLine($"sign = {sign}");
//В задании сказано что надо найти сумму всех натуральных элементов,
//если пользователь ввел отрицательное значение то считаем от 0
int nTmp = nUser < 0 ? 0 : nUser;
int mTmp = mUser < 0 ? 0 : mUser;
var naturalSum = SumIntegerNumbers(nTmp, mTmp, sign);

// Выводим на экран
Console.Clear();
string answer = $"\nCумма натуральных чисел \n";
answer += $"M = {mUser}; N = {nUser}";

Console.WriteLine($"{answer} -> {naturalSum.sum}\n\n{naturalSum.text} = {naturalSum.sum}");