int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число делится на 23 и на 7");
}
else
{
    Console.WriteLine("Число не делится ");
}