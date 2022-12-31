public class MyMethodsArray
{
    /// <summary>
    /// Метод ввода числового значения в консоль.
    /// </summary>
    /// <returns>Числовое значение типа int.</returns>
    public static int InputSizeArray()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
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
    /// Метод создания трехмерного массива типа int.
    /// </summary>
    /// <param name="lengthX">Количество элементов по оси X.</param>
    /// <param name="lengthY">Количество элементов по оси Y.</param>
    /// <param name="lengthZ">Количество элементов по оси Z.</param>
    /// <returns>Трехмерный массив.</returns>
    public static int[,,] NewArrayThree(int lengthX, int lengthY, int lengthZ)
    {
        return new int[lengthX, lengthY, lengthZ];
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
    /// Метод заполенния трехмерного массива целыми неповторяющимися случайными числами от 10 до 99 включительно.
    /// </summary>
    /// <param name="array">Трехмерный массив.</param>
    public static void FillArrayThree(int[,,] array)
    {
        bool tr;
        int number = 0;
        int lengthX = array.GetLength(0);
        int lengthY = array.GetLength(1);
        int lengthZ = array.GetLength(2);
        for (int i = 0; i < lengthX; i++)
        {
            for (int j = 0; j < lengthY; j++)
            {
                for (int k = 0; k < lengthZ; k++)
                {
                    number = Random.Shared.Next(10, 100);
                    tr = EqualityCheck(array, number);
                    if (tr)
                        array[i, j, k] = number;
                    else
                        k--;
                }
            }
        }
    }
    /// <summary>
    /// Метод поиска повторных чисел в трехмерном массиве.
    /// </summary>
    /// <param name="array">Трехмерный массив.</param>
    /// <param name="number">Число которое необходимо найти в массиве.</param>
    /// <returns>Возвращает false если число найдено.</returns>
    public static bool EqualityCheck(int[,,] array, int number)
    {
        bool tr = true;
        for (int n = 0; n < array.GetLength(0); n++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                for (int m = 0; m < array.GetLength(2); m++)
                {
                    if (array[n, l, m] == number)
                        tr = false;
                }
            }
        }
        return tr;
    }
    /// <summary>
    /// Метод записи двумерного массива типа int в переменную типа string.
    /// </summary>
    /// <param name="array">Двумерный массив типа int.</param>
    /// <returns>Переменная типа string.</returns>
    public static string PrintBivArray(int[,] array)
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
    /// <summary>
    /// Метод записи одномерного массива типа int в переменную типа string.
    /// </summary>
    /// <param name="array">Одномерный массив типа int.</param>
    /// <returns>Переменная типа string.</returns>
    public static string PrintArray(int[] array)
    {
        string text = string.Empty;
        int lengthLine = array.Length;
        for (int i = 0; i < lengthLine; i++)
        {
            text += $"Сумма строки {i}: {array[i],-4} ";
        }
        return text;
    }
    public static string PrintArrayThree(int[,,] array)
    {
        string text = string.Empty;
        int lengthX = array.GetLength(0);
        int lengthY = array.GetLength(1);
        int lengthZ = array.GetLength(2);
        for (int i = 0; i < lengthX; i++)
        {
            for (int j = 0; j < lengthY; j++)
            {
                for (int k = 0; k < lengthZ; k++)
                {
                    text += $"{array[i, j, k],-2}({i}, {j}, {k})  ";
                }
                text += "\n";
            }
            text += "\n";
        }
        return text;
    }
    /// <summary>
    /// Метод сортировки выбором.
    /// </summary>
    /// <param name="array">Двумерный массив типа int.</param>
    public static void Sort(int[,] array)
    {
        int maxIndex, maxElement;
        int lengthLine = array.GetLength(0);
        int lengthColumn = array.GetLength(1);
        for (int i = 0; i < lengthLine; i++)
        {
            for (int k = 0; k < lengthColumn; k++)
            {
                maxElement = array[i, k];
                maxIndex = k;
                for (int j = k + 1; j < lengthColumn; j++)
                {
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                        maxIndex = j;
                    }
                }
                array[i, maxIndex] = array[i, k];
                array[i, k] = maxElement;
            }
        }
    }
    /// <summary>
    /// Метод подсчета суммы элементов каждой строки двумерного массива типа int.
    /// </summary>
    /// <param name="array">Двумерный массив.</param>
    /// <returns>Одномерный массив типа int с сумами элементов каждой строки двумерного массива.</returns>
    public static int[] SumElementsRowsArray(int[,] array)
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
    /// <summary>
    /// Метод поиска минимального элемента одномерного массива типа int.
    /// </summary>
    /// <param name="array">Одномерный массив.</param>
    /// <returns>Индекс наименьшего элемента массива.</returns>
    public static int MinElemetsSum(int[] array)
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
    /// <summary>
    /// Метод нахождения произведения двух матриц.
    /// </summary>
    /// <param name="array1">Первая матрица.</param>
    /// <param name="array2">Вторая матрица.</param>
    /// <returns>Произведение матриц.</returns>
    public static int[,] MultiMatrix(int[,] array1, int[,] array2)
    {
        int lengthLine1 = array1.GetLength(0);
        int lengthColumn1 = array1.GetLength(1); // должно быть равно количеству строк второй матрицы
        int lengthLine2 = array2.GetLength(0);
        int lengthColumn2 = array2.GetLength(1);
        int sum = 0;
        int[,] multi = MyMethodsArray.NewArray(lengthLine1, lengthColumn2);
        for (int i = 0; i < lengthLine1; i++)
        {
            for (int j = 0; j < lengthColumn2; j++)
            {
                for (int k = 0; k < lengthColumn1; k++)
                {
                    sum += array1[i, k] * array2[k, j];
                }
                multi[i, j] = sum;
                sum = 0;
            }
        }
        return multi;
    }
}