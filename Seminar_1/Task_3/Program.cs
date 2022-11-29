/* Задача 3: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */
int N = new Random().Next(2, 21);
Console.WriteLine("Число N = {0}", N);
Console.WriteLine("Четыне числа от 1 до {0}: ", N);
int count = 1;
while (count <= N)
{
    {
        if ((count % 2) == 0)
        {
            Console.WriteLine(count);
        }
    }
    count++;
}