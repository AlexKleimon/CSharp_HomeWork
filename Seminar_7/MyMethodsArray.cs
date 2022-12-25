public class MyMethodsArray
{
    /// <summary>
    /// Метод заполнения двумерного массива типа double.
    /// </summary>
    /// <param name="line">Количество строк двумерного массива.</param>
    /// <param name="pillar">Количество столбцов двумерного массива.</param>
    /// <returns>Двумерный массив типа double.</returns>
    public static double[,] NewDoubleArray(int line, int pillar)
    {
        return new double[line, pillar];
    }
    /// <summary>
    /// Метод заполнения двумерного массива типа double. <br/>(На выбор: нулями, целыми либо вещественными числами.)
    /// </summary>
    /// <param name="array">Двумерный массив типа double.</param>
    /// <param name="min">Нижняя граница диапазона возможных значений.</param>
    /// <param name="max">Верхняя граница диапазона возможных значений.</param>
    /// <param name="choice">Выбор заполнения массива: 1 - заполнить массив вещественными числами;<br/>
    /// 0 - заполнить массив целыми числами;<br/>
    /// любое другое число - заполнить массив нулями.</param>
    public static void FillArray(double[,] array, int min, int max, int choice)
    {
        int lengthLine = array.GetLength(0);
        int lengthPillar = array.GetLength(1);
        if (choice == 1)
        {
            for (int i = 0; i < lengthLine; i++)
            {
                for (int j = 0; j < lengthPillar; j++)
                {
                    array[i, j] = Random.Shared.NextDouble() + Random.Shared.Next(min, max + 1);
                }
            }
        }
        else if (choice == 0)
        {
            for (int i = 0; i < lengthLine; i++)
            {
                for (int j = 0; j < lengthPillar; j++)
                {
                    array[i, j] = Random.Shared.Next(min, max + 1);
                }
            }
        }
        else
        {
            for (int i = 0; i < lengthLine; i++)
            {
                for (int j = 0; j < lengthPillar; j++)
                {
                    array[i, j] = 0;
                }
            }
        }

    }
    /// <summary>
    /// Метод запись двумерного массива типа double в переменную типа string.
    /// </summary>
    /// <param name="array">Двумерный массив типа double.</param>
    /// <returns>Переменная типа string.</returns>
    public static string Print(double[,] array)
    {
        string text = string.Empty;
        int lengthLine = array.GetLength(0);
        int lengthPillar = array.GetLength(1);
        for (int i = 0; i < lengthLine; i++)
        {
            for (int j = 0; j < lengthPillar; j++)
            {
                text += $"{array[i, j],-7:f2}";
            }
            text += "\n";
        }
        return text;
    }
    /// <summary>
    /// Метод запись одномерного массива типа double в переменную типа string.
    /// </summary>
    /// <param name="array">Одномерный массив типа double.</param>
    /// <returns>Переменная типа string.</returns>
    public static string PrintLineArray(double[] array)
    {
        string text = string.Empty;
        int lengthLine = array.GetLength(0);
        for (int i = 0; i < lengthLine; i++)
        {
            text += $"{array[i],-7:f2}";
        }
        return text;
    }
    /// <summary>
    /// Метод ввода числовых данных в консоль с проверкой.
    /// </summary>
    /// <returns>Входные данные типа int.</returns>
    public static int InputLinesPillar()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
    /// <summary>
    /// Метод подсчета среднего арифметического каждого столбца двумерного массива типа double.
    /// </summary>
    /// <param name="array">Двумерный массив типа double.</param>
    /// <returns>Одномерный массив типа double, заполненный средним арифметическим каждого столбца массива.</returns>
    public static double[] Average(double[,] array)
    {
        int lengthLine = array.GetLength(0);
        int lengthPillar = array.GetLength(1);
        double[] sumArray = new double[lengthPillar];
        double sum = 0;
        for (int i = 0; i < lengthPillar; i++)
        {
            for (int j = 0; j < lengthLine; j++)
            {
                sum += array[j, i];
            }
            sumArray[i] = sum / lengthLine;
            sum = 0;
        }
        return sumArray;
    }
}