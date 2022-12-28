public class Tasks_Seminar_8
{
    public static void Task56()
    {
        int[,] matrix = MyMethodsArray.NewArray(4, 7);
        MyMethodsArray.FillArray(matrix);
        int[] dataArray = MyMethodsArray.SumElementsRowsArray(matrix);
        Console.WriteLine(MyMethodsArray.Print(matrix)+$" {dataArray[0],-8}\n {dataArray[1],-8}\n {dataArray[2],-8}\n {dataArray[3],-8}");
        int index = MyMethodsArray.MinElemetsSum(dataArray);
        Console.Write(index + " сумма "+dataArray[index]);
    }
}