// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number == )
{
    Console.WriteLine("третьей цифры нет");
}
while (number >= 999)
{
    number = number / 10;
}
Console.WriteLine("третья цифра вводимого числа: " + number %10);