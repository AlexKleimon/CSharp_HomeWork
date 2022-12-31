public class Tasks_seminar_9
{
    /// <summary>
    /// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.<br/>
    /// N = 5 -> "5, 4, 3, 2, 1"<br/>
    /// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    /// </summary>
    public static void Task64()
    {
        Console.WriteLine("Введите число N: ");
        int N = MyMethods.Input();
        string result = MyMethods.SequenceN(N);
        Console.WriteLine($"N = {N} -> \"{result}");
    }
    /// <summary>
    /// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.<br/>
    /// M = 1; N = 15 -> 120<br/>
    /// M = 4; N = 8. -> 30
    /// </summary>
    public static void Task66()
    {
        Console.WriteLine("Введите число M: ");
        int M = MyMethods.Input();
        Console.WriteLine("Введите число N: ");
        int N = MyMethods.Input();
        int sum = MyMethods.SumMN(M, N);
        Console.WriteLine($"M = {M}; N = {N} -> {sum}");
    }
    /// <summary>
    /// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.<br/>
    /// m = 2, n = 3 -> A(m,n) = 9<br/>
    /// m = 3, n = 2 -> A(m,n) = 29
    /// </summary>
    public static void Task68()
    {
        Console.WriteLine("Введите число m чтобы посчитать А(m,n): ");
        int m = MyMethods.Input();
        Console.WriteLine("Введите число n чтобы посчитать А(m,n): ");
        int n = MyMethods.Input();
        int akr = MyMethods.Akerman(m, n);
        Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {akr}");
    }
}