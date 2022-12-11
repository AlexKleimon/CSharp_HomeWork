public class MyMathMethods
{
    /// <summary>
    /// Метод возведения числа в степень.
    /// </summary>
    /// <param name="number">Число, которое необходимо возвести в степень.</param>
    /// <param name="degree">Степень, в которую необходимо возвести число.</param>
    /// <returns>Число number возведенное в степень degree.</returns>
    public static double Pow(double number, int degree)
    {
        double result = 1;
        for (int index = 0; index < degree; index++)
        {
            result *= number;
        }
        return result;
    }
    /// <summary>
    /// Метод перевода числа из пятнадцатиричной системы счисления в десятичную.
    /// </summary>
    /// <param name="arry">Массив с числом пятнадцатиричной системы счисления.</param>
    /// <returns>Число типа double в десятиной системе счисления.</returns>
    public static double ConvDecimalSys(int[] arry)
    {
        double number10 = 0;
        int sizeArry = arry.Length;
        for (int i = 0; i < sizeArry; i++)
        {
            number10 += arry[i] * Pow(15, sizeArry - 1 - i);
        }
        return number10;
    }
    /// <summary>
    /// Метод позволяющий просуммировать цифры заданного целого числа.
    /// </summary>
    /// <param name="number">Целое число.</param>
    /// <returns>Сумма всех цифр целого числа.</returns>
    public static int SumDigitNumb(int number)
    {
        int sum = 0;
        number = Math.Abs(number);
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}