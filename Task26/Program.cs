//  Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



int InsertDigit(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int CountDigit(int insertNum)
{
    // insertNum = Math.Abs(insertNum);
    int temp = 0;
    while (insertNum != 0)
    {
        insertNum = insertNum / 10;
        temp++;
    }
}
int userNumber = InsertDigit("Введите число: ");
int count = CountDigit(userNumber);
Console.WriteLine($"Количество цифр в числе {userNumber} = {count}");
