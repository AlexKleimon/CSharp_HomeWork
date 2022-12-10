/*Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите количество чисел, которые будут отображаться в таблице кубов:");
int N = int.Parse(Console.ReadLine());
string result = String.Empty;
Console.WriteLine("-----------------------\n|  Число  | Куб числа |\n-----------------------");
for (int index = 1; index <= N; index++)
{
    result += $"| {index,-8}| {index * index * index,-10}|\n-----------------------\n";
}
Console.WriteLine(result);