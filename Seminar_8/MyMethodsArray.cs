public class MyMethodsArray
{
    /// <summary>
    /// Метод создания двумерного массива типа int.
    /// </summary>
    /// <param name="lengthLine">Количество строк двумерного массива.</param>
    /// <param name="lengthColumn">Количество столбцов двумерного массива.</param>
    /// <returns>Двумерный массив типа int.</returns>
    public static int[,] NewArray(int lengthLine, int lengthColumn)
    {
        return new int[lengthLine, lengthColumn];
    }
    /// <summary>
    /// Метод заполнения двумерного массива типа int случайными числами.
    /// </summary>
    /// <param name="array">Двумерный массив типа int.</param>
    public static void FillArray(int[,] array)
    {
        int lengthLine = array.GetLength(0);
        int lengthColumn = array.GetLength(1);
        for (int i = 0; i < lengthLine; i++)
        {
            for (int j = 0; j < lengthColumn; j++)
            {
                array[i, j] = Random.Shared.Next(0, 10);
            }
        }
    }
    /// <summary>
    /// Метод записи двумерного массива типа int в переменную типа string.
    /// </summary>
    /// <param name="array">Двумерный массив типа int.</param>
    /// <returns>Переменная типа string.</returns>
    public static string Print(int[,] array)
    {
        string text = string.Empty;
        int lengthLine = array.GetLength(0);
        int lengthColumn = array.GetLength(1);
        for (int i = 0; i < lengthLine; i++)
        {
            for (int j = 0; j < lengthColumn; j++)
            {
                text += $"{array[i, j],-4}";
            }
            text += "\n";
        }
        return text;
    }

    public static int [] SumElementsRowsArray(int[,] array)
    {
        int lengthLine = array.GetLength(0);
        int lengthColumn = array.GetLength(1);
        int[] dataArray = new int[lengthLine];
        int sum;
        for (int i = 0; i < lengthLine; i++)
        {
            sum = 0;
            for (int j = 0; j < lengthColumn; j++)
            {
                sum += array[i, j];
            }
            dataArray[i] = sum;
        }
        return dataArray;
    }

    public static int MinElemetsSum (int [] array)
    {
        int size = array.Length;
        int min = array[0];
        int index = 0;
        for (int i = 1; i < size; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        return index;
    }

}