// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
Console.WriteLine("Программа выводит функцию Аккермана");
Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AkkermanFunction(numberM, numberN));

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 & n == 0)
    {
        return AkkermanFunction(m-1, 1);
    }
    else if (m > 0 & n > 0)
     {
        return AkkermanFunction(m-1, AkkermanFunction(m, n-1));
    }

    return 0;
}