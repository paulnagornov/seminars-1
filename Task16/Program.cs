Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquare(number1, number2) ? "да" : "нет");
bool IsSquare(int n1, int n2)
{
    return n1 / n2 == n2 || n2 / n1 == n1;
}





