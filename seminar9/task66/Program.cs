// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Программа выводит сумму натуральные числа между Стартовым и Конечным числом");
Console.WriteLine("Введите cтартовое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Конечное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumEvenNumberFromMtoN(numberM, numberN));

int SumEvenNumberFromMtoN(int numberM, int numberN)
{
    if (numberM == numberN)
    {
        return numberM;
    }
    else if (numberM > numberN)
    {
        return numberM + SumEvenNumberFromMtoN(numberM - 1, numberN);
    }
    else
    {
        return numberM + SumEvenNumberFromMtoN(numberM + 1, numberN);
    }
}