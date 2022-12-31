public class MyMethods
{
    /// <summary>
    /// Метод ввода числового значения в консоль.
    /// </summary>
    /// <returns>Числовое значение типа int.</returns>
    public static int Input()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
    /// <summary>
    /// Метод вывода чисел от N до 1.
    /// </summary>
    /// <param name="N">Количество чисел.</param>
    /// <returns>Последовательность чисел, записанная в переменную string.</returns>
    public static string SequenceN(int N)
    {
        string sequence = string.Empty;
        if (N == 1)
            return "1\"";
        else
            return sequence += $"{N}, {SequenceN(N - 1)}";
    }
    /// <summary>
    /// Метод подсчета суммы последовательности чисел от M до N включительно.
    /// </summary>
    /// <param name="M">Нижняя граница диапазона чисел.</param>
    /// <param name="N">Верхняя граница диапазона чисел.</param>
    /// <returns>Сумма чисел от M до N.</returns>
    public static int SumMN(int M, int N)
    {
        if (N == M)
            return N;
        else
            return N + SumMN(M, N - 1);
    }
    /// <summary>
    /// Метод вычисления функции Акермана.
    /// </summary>
    /// <param name="m">Число функции A(m,n).</param>
    /// <param name="n">Число функции A(m,n).</param>
    /// <returns>Значение функции Акермана.</returns>
    public static int Akerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (n == 0 && m > 0)
            return Akerman(m - 1, 1);
        else
            return Akerman(m - 1, Akerman(m, n - 1));
    }
}