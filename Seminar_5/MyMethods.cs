/// <summary>
/// Различные математические методы с числами в одномерных массивах.
/// </summary>
public class MyMethods
{
    /// <summary>
    /// Метод подсчета четных чисел в одномерном массиве.
    /// </summary>
    /// <param name="array">Одномерный массив чисел.</param>
    /// <returns>Количество четных чисел в одномерном массиве.</returns>
    public static int EvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                count++;
        }
        return count;
    }
    /// <summary>
    /// Метод подсчета суммы чисел, стоящих на нечетных позициях массива.
    /// </summary>
    /// <param name="array">Одномерный массив чисел.</param>
    /// <returns>Сумма чисел.</returns>
    public static int SumOddNumbers(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }
}