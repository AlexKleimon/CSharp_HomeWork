//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//Строки использовать нельззя
Console.WriteLine("Введите число, чтобы узнать сумму цифр этого числа:");
int number = int.Parse(Console.ReadLine());
int sizeNumb = (int)Math.Log10(number) + 1;
int sum = 0;
for (int index = 0; index < sizeNumb; index++)
{
    sum += (number / ((int) Math.Pow(10, index))) % 10;
}
Console.WriteLine($"Сумма цифр числа {number} равна: {sum}");