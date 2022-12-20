public class Tasks_seminar_6
{
    /// <summary>
    /// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    /// <para>Пример:<br/>
    /// 0, 7, 8, -2, -2 -> 2<br/>
    /// 1, -7, 567, 89, 223-> 3</para>
    /// </summary>
    public static void Task_41()
    {
        Console.WriteLine("Какое количество чисел хотите ввести?");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < number; i++)
        {
            count += MyMethods.Count(MyMethods.InputNumber());
        }
        Console.WriteLine($"Количество чисел, значение которых больше нуля, равно: {count}");
    }
    /// <summary>
    /// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных<br/>
    /// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    /// <para>Пример:<br/>
    /// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)</para>
    /// </summary>
    public static void Task_43()
    {
        Console.WriteLine("Поиск точки пересечений прямых y=k1*x+b1 и y=k2*x+b2:");
        float[] arry = MyMethods.InputParamLines();
        MyMethods.Intersection(arry);

    }
}