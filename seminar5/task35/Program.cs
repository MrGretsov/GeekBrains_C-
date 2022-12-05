﻿// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int [] CreateArray ()
{
int [] massive = new int[new Random().Next(1, 100)];
int i = 0;
while (i <= (massive.Length - 1))
{
    massive[i] = new Random().Next(0, 100);
    i ++;
}
Console.WriteLine($"Массив: {string.Join(", ", massive)}");
return massive;
}