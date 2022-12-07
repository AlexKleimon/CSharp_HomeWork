/* Зажача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (0,0); B (1,1), -> ~1.4
A (2,4); B (0,7) -> ~3.6
*/
Console.WriteLine("Введите координату X точки А:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Xточки B:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B:");
double y2 = double.Parse(Console.ReadLine());
double Range = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между точками A ({x1}, {y1}) и B ({x2}, {y2}) равно: {Range}.");