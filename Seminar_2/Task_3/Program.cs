/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6, 7 - выходной.
НО дня с индексом 0 или 12 не существует.
6 -> да
7 -> да
1 -> нет
*/
while (true)
{
    int numberDay = int.Parse(Console.ReadLine());
    if (numberDay > 0 && numberDay < 8)
    {
        if (numberDay == 6 || numberDay == 7)
            Console.WriteLine($"День под номером {numberDay} является выходным днём.");
        else
            Console.WriteLine($"День под номером {numberDay} не является выходным днём.");
        break;
    }
}