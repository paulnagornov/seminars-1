// Напишите цикл, который принимает на вход два числа (А, В) и
// возводит число А в натуральную степень числа В.


int UserInput(string text)
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int userNumber1 = UserInput("Введите число A - ");
int userNumber2 = UserInput("Введите число B - ");
double powerNumber =
    userNumber2 > 0
        ? PowerNumber(userNumber1, userNumber2)
        : 1 / PowerNumber(userNumber1, -userNumber2);
Console.Write($"{userNumber1}, {userNumber2} -> {powerNumber}");
double PowerNumber(int a, int b)
{
    double power = 1;
    for (int col = 1; col <= b; power *= a, col++);
    return power;
}
