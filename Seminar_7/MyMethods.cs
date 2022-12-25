public class MyMethods
{
    /// <summary>
    /// Метод заполнения двумерного массива типа string.
    /// </summary>
    /// <param name="line">Количество строк двумерного массива.</param>
    /// <param name="pillar">Количество столбцов двумерного массива.</param>
    /// <returns>Двумерный массив типа string.</returns>
    public static string[,] newArrayString(int lengthLine, int lengthPillar)
    {
        return new string[lengthLine, lengthPillar];
    }
    /// <summary>
    /// Метод заполнения двумерного массива типа string случайными словами одномерного массива типа string
    /// </summary>
    /// <param name="array">Двумерный массив типа string.</param>
    /// <param name="textArray">Одномерный массив типа string.</param>
    public static void FillRandomStringArray(string[,] array, string[] textArray)
    {
        int lengthLine = array.GetLength(0);
        int lengthPillar = array.GetLength(1);
        int lengthText = textArray.Length;
        for (int i = 0; i < lengthLine; i++)
        {
            for (int j = 0; j < lengthPillar; j++)
            {
                int posRandomWord = Random.Shared.Next(0, lengthText);
                array[i, j] = textArray[posRandomWord];
            }
        }
    }
    /// <summary>
    /// Метод записи двумерного массива типа string в переменную типа string.
    /// </summary>
    /// <param name="arrayWords">Двумерный массив типа string.</param>
    /// <returns>Переменная типа string.</returns>
    public static string PrintStringArray(string[,] arrayWords)
    {
        string words = string.Empty;
        int lengthLine = arrayWords.GetLength(0);
        int lengthPillar = arrayWords.GetLength(1);
        for (int i = 0; i < lengthLine; i++)
        {
            for (int j = 0; j < lengthPillar; j++)
            {
                words += $"{arrayWords[i, j],-12}";
            }
            words += "\n";
        }
        return words;
    }
    /// <summary>
    /// Метод подсчета слов содержащих символов '!' в двумерном массиве типа string.
    /// </summary>
    /// <param name="arrayWords">Двумерный массив типа string.</param>
    /// <returns>Количество слов.</returns>
    public static int CountWords(string[,] arrayWords)
    {
        int lengthLine = arrayWords.GetLength(0);
        int lengthPillar = arrayWords.GetLength(1);
        int count = 0;
        for (int i = 0; i < lengthLine; i++)
        {
            for (int j = 0; j < lengthPillar; j++)
            {
                string word = arrayWords[i, j];
                int lengthWord = word.Length;
                for (int m = 0; m < lengthWord; m++)
                {
                    if (word[m] == '!')
                    {
                        count++;
                        break;
                    }
                }
            }
        }
        return count;
    }

}