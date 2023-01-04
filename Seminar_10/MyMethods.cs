public class MyMethods
{
    public static void FillSpilarArray(int[,] array)
    {
        int number = 1;
        for (int j = 0; j < 4; j++)
        {
            array[0, j] = number;
            number++;
        }
        for (int i = 1; i < 4; i++)
        {
            array[i, 3] = number;
            number++;
        }
        for (int j = 2; j >= 0; j--)
        {
            array[3, j] = number;
            number++;
        }
        for (int i = 2; i >= 1; i--)
        {
            array[i, 0] = number;
            number++;
        }
        for (int j = 1; j < 3; j++)
        {
            array[1, j] = number;
            number++;
        }
        array[2, 2] = number;
        number++;
        array[2, 1] = number;
    }
    public static string Print(int[,] array)
    {
        string text = String.Empty;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                text += $"{array[i, j],-5}";
            }
            text += "\n";
        }
        return text;
    }
}
/*  0 1 2 3 j
 0  1 2 3 4
 1        5
 2        6
 3      8 7
 i


*/