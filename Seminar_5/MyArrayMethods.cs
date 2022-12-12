/// <summary>
/// Методы работы с массивами.
/// </summary>
public class MyArrayMethods
{
    /// <summary>
    /// Метод создания одномерного массива.
    /// </summary>
    /// <param name="numbArray">Количество элементов в массиве.</param>
    /// <returns>Одномерный массив из numbArray элементов.</returns>
    public static int[] newArray(int numbArray)
    {
        return new int[numbArray];
    }
    /// <summary>
    /// Метод заполнения массива случайными числами.
    /// </summary>
    /// <param name="min">Нижняя граница диапазона возможных значений.</param>
    /// <param name="max">Верхняя граница диапазонна возможных значений.</param>
    /// <param name="arry">Массив, который необходимо заполнить случайными числами.</param>
    public static void fillArray(int min, int max, int[] arry)
    {
        int size = arry.Length;
        for (int i = 0; i < size; i++)
        {
            arry[i] = Random.Shared.Next(min, max);
        }
    }
    /// <summary>
    /// Метод записи массива в переменную типа String.
    /// </summary>
    /// <param name="arry">Массив, который необходимо записать в переменную типа String.</param>
    /// <returns>Переменная типа String.</returns>
    public static string Print(int[] arry)
    {
        string Print = String.Join(",", arry);
        Console.Write("Массив: ");
        return $"[{Print}]";
    }
}