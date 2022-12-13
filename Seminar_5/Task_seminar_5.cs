/// <summary>
/// Задачи 34, 36 и 38.
/// </summary>
public class Task_seminar_5
{
    /// <summary>
    /// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    /// <para>Пример:<br/>[345, 897, 568, 234] -> 2. </para>
    /// </summary>
    public static void Task_34()
    {
        Console.WriteLine("Введите количество элементов массива: ");
        int numberSize = int.Parse(Console.ReadLine());
        int[] arry = MyArrayMethods.newArray(numberSize);
        MyArrayMethods.fillArray(100, 1000, arry);
        Console.WriteLine(MyArrayMethods.Print(arry));
        int count = MyMethods.EvenNumbers(arry);
        Console.WriteLine($"Количество четных чисел в массиве равно: {count}.");
    }
    /// <summary>
    /// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    ///<para>Пример:<br/>[3, 7, 23, 12] -> 19;<br/>[-4, -6, 89, 6] -> 0.</para>
    /// </summary>
    public static void Task_36()
    {
        Console.WriteLine("Введите количество элементов массива:");
        int numberSize = int.Parse(Console.ReadLine());
        int[] arry = MyArrayMethods.newArray(numberSize);
        MyArrayMethods.fillArray(0, 10, arry);
        Console.WriteLine(MyArrayMethods.Print(arry));
        int sum = MyMethods.SumOddNumbers(arry);
        Console.WriteLine($"Сумма чисел стоящих на нечётных позициях в массиве равна: {sum}.");
    }
}