// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow
Console.WriteLine("Введите число, которое нужно возвести в степень:");
double numberA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно возвести число:");
int numberB = int.Parse(Console.ReadLine());
double result = 1;
for (int index = 0; index < numberB; index++)
{
    result *= numberA;
}
Console.WriteLine($"Число {numberA} в степени {numberB} равно: {result}.");