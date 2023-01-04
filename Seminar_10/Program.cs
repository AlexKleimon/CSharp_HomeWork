/*  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
*/
int[,] arry = new int[4,4];
MyMethods.FillSpilarArray(arry);
Console.WriteLine(MyMethods.Print(arry));
