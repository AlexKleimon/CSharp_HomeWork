using static MyArrayMethods;
using static MyMathMethods;
public class Task_seminar_4
{
    /// <summary>
    /// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15. 
    /// <para> Пример: N: 3 [9, 4, 12] => 2097</para>
    /// </summary>
    static public void Task_29()
    {
        Console.WriteLine("Введите количество элементов массива:");
        int number = int.Parse(Console.ReadLine());
        int[] arry = newArray(number);
        fillArray(0, 15, arry);
        Console.WriteLine("Число в 15-ой системе счисления: {0}", Print(arry));
        double number10 = ConvDecimalSys(arry);
        Console.WriteLine($"Число в 10-ой системе счисления: {number10}");
    }
    /// <summary>
    /// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    ///<para>
    /// Пример:<br/>
    /// 452 -> 11<br/>
    /// 82 -> 10<br/>
    /// 9012 -> 12<br/>
    ///</para>
    /// Строки использовать нельзя.
    /// </summary>
    static public void Task_27()
    {
        Console.WriteLine("Введите число, чтобы узнать сумму цифр этого числа:");
        int number = int.Parse(Console.ReadLine());
        int sum = SumDigitNumb(number);
        Console.WriteLine($"Сумма цифр числа {number} равна: {sum}");
    }
    /// <summary>
    ///Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    ///<para>
    ///Пример:<br/>
    ///3, 5 -> 243 (3⁵);<br/>
    ///2, 4 -> 16.<br/>
    ///</para>
    ///НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow.
    /// </summary>
    static public void Task_25()
    {
        Console.WriteLine("Введите число, которое нужно возвести в степень:");
        double numberA = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите степень, в которую нужно возвести число:");
        int numberB = int.Parse(Console.ReadLine());
        double result = Pow(numberA, numberB);
        Console.WriteLine($"Число {numberA} в степени {numberB} равно: {result}.");
    }
}