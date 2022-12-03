/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
while (true) 
{
    Console.WriteLine("Введите трёхзначное число: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 99 && number < 1000) // Трехёзначное ли число?
    {
        int numberTwo = (number % 100) / 10;
        Console.WriteLine($"Второй цифрой числа {number} является {numberTwo}");
        break;
    }
}