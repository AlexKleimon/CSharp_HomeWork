/*Задача 1: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int a = new Random().Next(-9, 10);
int b = new Random().Next(-9, 10);
int c = new Random().Next(-9, 10);
Console.WriteLine("a = {0}, b = {1}, c = {2};", a, b, c);
int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Max = {0}", max);