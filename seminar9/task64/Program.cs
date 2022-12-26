// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Программа выводит все натуральные числа между Стартовым и Конечным числом");
Console.WriteLine("Введите cтартовое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Конечное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());

PrintNumberToN(numberN, numberM);

void PrintNumberToN(int numberN, int numberM = 1)
{
    if (numberN == numberM)
    {
        Console.Write(numberN + " ");
        return;
    }
    else if (numberN > numberM)
    {
        PrintNumberToN(numberN - 1, numberM);
        Console.Write(numberN + " ");
    }
    else
    {
        PrintNumberToN(numberN + 1, numberM);
        Console.Write(numberN + " ");
    }
}