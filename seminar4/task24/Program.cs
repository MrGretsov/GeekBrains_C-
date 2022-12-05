//  Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Write("Введите число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = 0;
while(number_1 >= 0)
{
    number_2 +=number_1;
    number_1 -= 1;
}
Console.WriteLine(number_2);