/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
Console.WriteLine("Введите число:");
string numberFull = Console.ReadLine();
int count = numberFull.Length;
int numberThree = int.Parse(numberFull);;
Console.WriteLine(count);
if (count > 2)
{
    for (int index = 3; index < count; index++)
    {
        numberThree = numberThree / 10;
    }
    numberThree = numberThree % 10;
    Console.WriteLine($"Третей цифрой числа {numberFull} является: {numberThree}.");
}
else
Console.WriteLine($"У числа {numberFull} нету третей цифры.");


