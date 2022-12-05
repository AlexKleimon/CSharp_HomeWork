/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

while (true)
{
    Console.WriteLine("Введите пятизначное число:");
    int number = int.Parse(Console.ReadLine());
    if (number > 9999 && number < 100000)
    {
        int number1 = number / 10000;
        int number2 = (number / 1000) % 10;
        int number4 = (number % 100) / 10;
        int number5 = number % 10;
        if (number1 == number5 && number2 == number4)
            Console.WriteLine($"Число {number} является палиндромом.");
        else
            Console.WriteLine($"Число {number} не является палиндромом.");
        break;
    }
}