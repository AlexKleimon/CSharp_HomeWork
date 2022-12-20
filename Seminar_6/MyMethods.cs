public class MyMethods
{
    /// <summary>
    /// Метод ввода числа типа int пользователем.
    /// </summary>
    /// <returns>Введенное число типа int.</returns>
    public static int InputNumber()
    {
        Console.Write($"Введите число: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    /// <summary>
    /// Метод проверки числа на положительность.
    /// </summary>
    /// <param name="number">Число типа int.</param>
    /// <returns> Единица если число положительное, и ноль если нет.</returns>
    public static int Count(int number)
    {
        int count = 0;
        if (number > 0)
            count++;
        return count;
    }
    /// <summary>
    /// Метод ввода коэффициентов прямых y = k1*x+b1 и y = k2*x+b2.
    /// </summary>
    /// <returns>Массив значений коэффициентов.</returns>
    public static float[] InputParamLines()
    {
        string[] Param = { "k1", "b1", "k2", "b2" };
        float[] ParamArray = new float[4];
        for (int index = 0; index < 4; index++)
        {
            Console.Write($"Введите коэффициент {Param[index]}: ");
            ParamArray[index] = float.Parse(Console.ReadLine());
        }
        return ParamArray;
    }
    /// <summary>
    /// Метод подсчета точки пересечения прямых y = k1*x+b1 и y = k2*x+b2.
    /// </summary>
    /// <param name="DataArray">Массив значений коэффициентов.</param>
    public static void Intersection(float[] DataArray)
    {
        float x = (DataArray[3] - DataArray[1]) / (DataArray[0] - DataArray[2]);
        float y = DataArray[0] * x + DataArray[1];
        Console.WriteLine($"({x},{y}) - координаты точки пересечения двух прямых.");
    }
}