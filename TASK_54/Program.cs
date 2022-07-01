/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
void SortString(int[,] SortToArray)
{
    int temp = -1;
    for (var i = 0; i < SortToArray.GetLength(0); i++)
    {
        for (int k = 0; k < SortToArray.GetLength(1); k++)
        {
            for (var j = 0; j < SortToArray.GetLength(1) - 1 - k; j++)
            {
                if (SortToArray[i, j] > SortToArray[i, j + 1])
                {
                    temp = SortToArray[i, j];
                    SortToArray[i, j] = SortToArray[i, j + 1];
                    SortToArray[i, j + 1] = temp;
                }
            }
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
void Print2DArray(int[,] arrayToPrint, string name = "")
{
    PrintHeaderOfArray(arrayToPrint.GetLength(1), name);
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        System.Console.Write($"[{i}]\t");
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write($"{arrayToPrint[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = new int[3, 4];
GenerateArray(array);
Print2DArray(array, "Неотсортированный массив");
SortString(array);
Print2DArray(array, "Отсортированный массив");