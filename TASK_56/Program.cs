/*
 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 */

 void GenerateArray(int[,] arrayToGenerate)
{
    for (var i = 0; i < arrayToGenerate.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToGenerate.GetLength(1); j++)
        {
            arrayToGenerate[i, j] = new Random().Next(0, 20);
        }
    }
}
void FindStringMaximumSumOfElements(int[,] FindSumToArray, ref int min, ref int numberSt)
{
    int sum = 0;
    min = FindSumToArray.GetLength(1) * 20;
    numberSt = 0;
    for (var i = 0; i < FindSumToArray.GetLength(0); i++)
    {
        sum = 0;
        for (var j = 0; j < FindSumToArray.GetLength(1); j++)
        {
            sum = sum + FindSumToArray[i, j];
        }
        if (min > sum)
        {
            min = sum;
            numberSt = i;
        }
    }
}
void PrintHeaderOfArray(int lenght, string name = "")
{
    if (!string.IsNullOrEmpty(name))
    {
        System.Console.WriteLine($"----------{name}----------");
    }
    System.Console.Write($"[]\t");
    for (var i = 0; i < lenght; i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
}
void Print2DArray(int[,] arrayToPrint, int colorString, string name = "")
{
    PrintHeaderOfArray(arrayToPrint.GetLength(1), name);
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        if (i == colorString)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ResetColor();
        }
        System.Console.Write($"[{i}]\t");
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write($"{arrayToPrint[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
    System.Console.WriteLine("--------------------------------------------------------------");
}

int[,] array = new int[5, 5];
int minSum = 0;
int numberString = 0;

GenerateArray(array);
FindStringMaximumSumOfElements(array, ref minSum, ref numberString);
Print2DArray(array, numberString, "Поиск стоки с минимальной суммой элементов");
System.Console.WriteLine($"В строке [{numberString}] наименьшая сумма элементов ({minSum}) ");