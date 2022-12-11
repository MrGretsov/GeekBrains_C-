// Задайте массив натуральных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}
(int, int) GetSumPositiveAndNegative(int[] array)
{
    int max = 0;
    int min = 0;
for (int i = 0; i < array.Length; i++)   
    {
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
    return (max, min);
}

const int SIZE = 12;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 99;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));
(int sumP,int sumN) = GetSumPositiveAndNegative(arr);
Console.WriteLine($"Разница между максимальным значением массива и минимальным равна : {sumP}");
