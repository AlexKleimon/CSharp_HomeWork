public class Tasks_Seminar_8
{
    /// <summary>
    /// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    /// <para>Например, задан массив:<br/>
    /// 1 4 7 2<br/>
    /// 5 9 2 3<br/>
    /// 8 4 2 4<br/>
    /// В итоге получается вот такой массив:<br/>
    /// 7 4 2 1<br/>
    /// 9 5 3 2<br/>
    /// 8 4 4 2</para>
    /// </summary>
    public static void Task54()
    {
        Console.Write("Введите количество строк массива: ");
        int lengthLine = MyMethodsArray.InputSizeArray();
        Console.Write("Введите количество столбцов массива: ");
        int lengthColumn = MyMethodsArray.InputSizeArray();
        int[,] matrix = MyMethodsArray.NewArray(lengthLine, lengthColumn);
        MyMethodsArray.FillArray(matrix);
        Console.WriteLine(MyMethodsArray.PrintBivArray(matrix));
        MyMethodsArray.Sort(matrix);
        Console.WriteLine(MyMethodsArray.PrintBivArray(matrix));
    }
    /// <summary>
    /// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    /// <para>Например, задан массив:<br/>
    /// 1 4 7 2<br/>
    /// 5 9 2 3<br/>
    /// 8 4 2 4 <br/>
    /// 5 2 6 7<br/>
    /// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка</para>
    /// </summary>
    public static void Task56()
    {
        int[,] matrix = MyMethodsArray.NewArray(7, 4);
        MyMethodsArray.FillArray(matrix);
        int[] dataArray = MyMethodsArray.SumElementsRowsArray(matrix);
        string printMatrix = MyMethodsArray.PrintBivArray(matrix);
        string printDataArray = MyMethodsArray.PrintArray(dataArray);
        Console.WriteLine($"Массив:\n{printMatrix}{printDataArray}");
        int index = MyMethodsArray.MinElemetsSum(dataArray);
        Console.Write($"Строкой с наименьшей суммой элементов является строка под индексом {index}, чья сумма равна: {dataArray[index]}.");
    }
    /// <summary>
    /// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
    /// добавляя индексы каждого элемента.
    /// <para>Массив размером 2 x 2 x 2<br/>
    /// 66(0,0,0) 25(0,1,0)<br/>
    /// 34(1,0,0) 41(1,1,0)<br/>
    /// 27(0,0,1) 90(0,1,1)<br/>
    /// 26(1,0,1) 55(1,1,1)</para>
    /// </summary>
    public static void Task60()
    {
        int[,,] arrayXYZ = MyMethodsArray.NewArrayThree(3, 3, 3);
        MyMethodsArray.FillArrayThree(arrayXYZ);
        string text = MyMethodsArray.PrintArrayThree(arrayXYZ);
        Console.WriteLine(text);//
    }
    /// <summary>
    /// Сложная | можно пропустить<br/>
    /// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    /// <para>Например, даны 2 матрицы:<br/>
    /// 2 4 | 3 4<br/>
    /// 3 2 | 3 3<br/>
    /// Результирующая матрица будет:<br/>
    /// 18 20<br/>
    /// 15 18</para>
    /// </summary>
    public static void Task58()
    {
        Console.WriteLine("Введите количество строк первой матрицы: ");
        int lengthLine1 = MyMethodsArray.InputSizeArray();
        Console.WriteLine("Введите количество столбцов первой матрицы: ");
        int lengthColumn1 = MyMethodsArray.InputSizeArray();
        Console.WriteLine("Введите количество строк второй матрицы: ");
        int lengthLine2 = MyMethodsArray.InputSizeArray();
        Console.WriteLine("Введите количество столбцов второй матрицы: ");
        int lengthColumn2 = MyMethodsArray.InputSizeArray();
        int[,] matrix1 = MyMethodsArray.NewArray(lengthLine1, lengthColumn1);
        int[,] matrix2 = MyMethodsArray.NewArray(lengthLine2, lengthColumn2);
        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            MyMethodsArray.FillArray(matrix1);
            MyMethodsArray.FillArray(matrix2);
            Console.WriteLine($"Первая матрица:\n{MyMethodsArray.PrintBivArray(matrix1)}");
            Console.WriteLine($"Вторая матрица:\n{MyMethodsArray.PrintBivArray(matrix2)}");
            int[,] matrixMulti = MyMethodsArray.MultiMatrix(matrix1, matrix2);
            Console.WriteLine($"Итоговая матрица:\n{MyMethodsArray.PrintBivArray(matrixMulti)}");
        }
        else
            Console.WriteLine("Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы.");
    }
}