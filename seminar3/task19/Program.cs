// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int reverse = 0;
int n = num;

bool isPalindrome(int num)
{
    while (n > 0)
    {
        int lastNum = n % 10;
        reverse = reverse * 10 + lastNum;
        n = n / 10;

    }
    return (num == reverse);
}

Console.Write(isPalindrome(num) ? "Введёное вами число является палиндромом" : "Введёное вами число не является палиндромом");