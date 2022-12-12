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
}