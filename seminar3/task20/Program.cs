// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.Write("Введите A1 -> ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите A2 -> ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите B1 -> ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите B2 -> ");
double y2 = Convert.ToDouble(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) +
Math.Pow(y2 - y1, 2));

Console.WriteLine($"Расстояние = {distance:f2}");