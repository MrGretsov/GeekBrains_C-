// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number == 0)
{
    Console.WriteLine ("Количество цифрр в этом числе: " + count);
}
else
{
    while (number >0)
    {
    number = number/10;
    count += 1;
    }
    Console.WriteLine("Количество цифр в числе " + count);
}
