public class Task_seminar_5
{
    public static void Task_34()
    {
        Console.WriteLine("Введите количество элементов массива: ");
        int numberSize = int.Parse(Console.ReadLine());
        int[] arry = MyArrayMethods.newArray(numberSize);
        MyArrayMethods.fillArray(100, 1000, arry);
        Console.WriteLine(MyArrayMethods.Print(arry));
    }
}