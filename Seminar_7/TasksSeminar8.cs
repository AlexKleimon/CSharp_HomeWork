class TasksSeminar8
{
    /// <summary>
    /// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    /// <para>Пример:
    /// m = 3, n = 4.<br/>
    /// 0,5     7    -2    -0,2<br/>
    ///   1  -3,3     8    -9,9<br/>
    ///   8   7,8  -7,1       9</para>
    /// </summary>
    public static void Task47()
    {
        Console.WriteLine("Введите количество строк в массиве:");
        int lengthLine = MyMethodsArray.InputLinesPillar();
        Console.WriteLine("Введите количество столбцов в массиве:");
        int lengthPillar = MyMethodsArray.InputLinesPillar();
        double[,] arry = MyMethodsArray.NewDoubleArray(lengthLine, lengthPillar);
        MyMethodsArray.FillArray(arry, 0, 100, 1);
        string text = MyMethodsArray.Print(arry);
        Console.WriteLine(text);
    }
    /// <summary>
    /// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
    /// что такого элемента нет.
    /// <para>Например, задан массив:<br/>
    /// 1 4 7 2<br/>
    /// 5 9 2 3<br/>
    /// 8 4 2 4<br/>
    /// 17 -> такого числа в массиве нет</para>
    /// </summary>
    public static void Task50()
    {
        Console.WriteLine("Введите номер строки массива, в которой находится нужное число:");
        int positionLines = MyMethodsArray.InputLinesPillar();
        Console.WriteLine("Введите номер столбца массива, в котором находится нужное число:");
        int positionPillar = MyMethodsArray.InputLinesPillar();
        int lengthLine = Random.Shared.Next(3, 11);
        int lengthPillar = Random.Shared.Next(3, 11);
        double[,] arry = MyMethodsArray.NewDoubleArray(lengthLine, lengthPillar);
        MyMethodsArray.FillArray(arry, 0, 10, 1);
        Console.WriteLine(MyMethodsArray.Print(arry));
        if (lengthLine <= positionLines || lengthPillar <= positionPillar)
            Console.WriteLine($"Элемента с индекосами [{positionLines,-2}, {positionPillar,1}] в массиве нет.");
        else
        {
            Console.WriteLine($"\nЭлемент массива с индекасми [{positionLines,-2}, {positionPillar,1}] равен: {arry[positionLines, positionPillar]:f2}.");
        }

    }
    /// <summary>
    /// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    /// <para>Например, задан массив:<br/>
    /// 1 4 7 2<br/>
    /// 5 9 2 3<br/>
    /// 8 4 2 4<br/>
    /// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.</para>
    /// </summary>
    public static void Task52()
    {
        int lengthLine = Random.Shared.Next(3, 11);
        int lengthPillar = Random.Shared.Next(3, 11);
        double[,] arry = MyMethodsArray.NewDoubleArray(lengthLine, lengthPillar);
        MyMethodsArray.FillArray(arry, 0, 10, 0);
        Console.WriteLine("Двумерный массив целых чисел:");
        Console.WriteLine(MyMethodsArray.Print(arry));
        double[] average = MyMethodsArray.Average(arry);
        Console.WriteLine("Среднее арифметическое каждого столбца:");
        Console.WriteLine(MyMethodsArray.PrintLineArray(average));
    }
    /// <summary>
    /// Создать приложение по обработке двумерного массива строк.<br/>
    /// Приложение позволяет сгенерирвать массив и показать сколько в этом массиве "слов" содержащих восклицательный знак ("!").<br/>
    /// Требование: минимум 4 метода, IndexOf использовать нельзя.<br/>
    /// </summary>
    public static void TaskAddit()
    {
        Console.WriteLine("Введите количество строк в массиве:");
        int lengthLine = MyMethodsArray.InputLinesPillar();
        Console.WriteLine("Введите количество столбцов в массиве:");
        int lengthPillar = MyMethodsArray.InputLinesPillar();
        string[,] arrayWords = MyMethods.newArrayString(lengthLine, lengthPillar);
        string[] textArray = {"Hi!","good","beckon","nice!","flowchart","long","office","physically","NO!","alone!!!","pizza...",
                                "wondows","food","clear","clone","lists","BLACK!","Yellow?","Who?","BOSS!", "FLY!!!", "jobs!","player0_0"};
        MyMethods.FillRandomStringArray(arrayWords, textArray);
        Console.WriteLine(MyMethods.PrintStringArray(arrayWords));
        Console.WriteLine($"Количество слов с восклицательным знаком равно: {MyMethods.CountWords(arrayWords)}.");
    }
}