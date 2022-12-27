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

}