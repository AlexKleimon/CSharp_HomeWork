public class Tasks_Seminar_8
{
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
}