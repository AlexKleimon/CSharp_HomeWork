/// <summary>
/// Методы работы с массивами.
/// </summary>
public class MyArrayMethods
{
    /// <summary>
    /// Метод создания одномерного массива типа int.
    /// </summary>
    /// <param name="numbArray">Количество элементов в массиве.</param>
    /// <returns>Одномерный массив из numbArray элементов.</returns>
    public static int[] newArray(int numbArray)
    {
        return new int[numbArray];
    }
    /// <summary>
    /// Метод создания одномерного массива типа float.
    /// </summary>
    /// <param name="numbArray">Количество элементов в массиве.</param>
    /// <returns>Одномерный массив из numbArray элементов.</returns>
    public static float[] newArrayF(int numbArray)
    {
        return new float[numbArray];
    }
    /// <summary>
    /// Метод заполнения массива случайными числами (min,max] типа int.
    /// </summary>
    /// <param name="min">Нижняя граница диапазона возможных значений.</param>
    /// <param name="max">Верхняя граница диапазонна возможных значений.</param>
    /// <param name="arry">Массив, который необходимо заполнить случайными числами.</param>
    public static void fillArray(int min, int max, int[] arry)
    {
        for (int i = 0; i < arry.Length; i++)
        {
            arry[i] = Random.Shared.Next(min, max);
        }
    }
    /// <summary>
    ///Метод заполнения массива случайными числами (0,max] типа float.
    /// </summary>
    /// <param name="max">Верхняя граница диапазона значений.</param>
    /// <param name="arry">Массив, который необходимо заполнить случайными числами.</param>
    public static void fillArrayF(double max, float[] arry)
    {
        for (int i = 0; i < arry.Length; i++)
        {
            arry[i] = (float)(Random.Shared.NextDouble() * max);
        }
    }
    /// <summary>
    /// Метод записи массива типа int в переменную типа string.
    /// </summary>
    /// <param name="arry">Массив, который необходимо записать в переменную типа string.</param>
    /// <returns>Переменная типа string.</returns>
    public static string Print(int[] arry)
    {
        string Print = String.Join(",", arry);
        Console.Write("Массив: ");
        return $"[{Print}]";
    }
    /// <summary>
    /// Метод записи массива типа float в переменную типа string.
    /// </summary>
    /// <param name="arry">Массив, который необходимо записать в переменную типа string.</param>
    /// <returns>Переменная типа string.</returns>
    public static string PrintF(float[] arry)
    {
        string Print = String.Join(" , ", arry);
        Console.Write("Массив: ");
        return $"[{Print}]";
    }
    /// <summary>
    /// Метод нахождения разности максимального и минимального элементов массива типа float.
    /// </summary>
    /// <param name="arry">Одномерный массив типа float.</param>
    /// <returns>Разность максимального и минимального элементов массива.</returns>
    public static float MinMax(float[] arry)
    {
        float min = arry[0];
        float max = arry[0];
        for (int i = 0; i < arry.Length; i++)
        {
            if (arry[i] > max)
                max = arry[i];
            else if (arry[i] < min)
                min = arry[i];
        }
        return max - min;
    }
}