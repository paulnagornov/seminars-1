Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = -number;
while (counter <= number)
{
    Console.Write(counter + " ");
    counter++;
}
