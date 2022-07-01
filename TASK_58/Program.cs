/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

void GenerateMatrix(int[,] MatrixToGenerate)
{
    for (var i = 0; i < MatrixToGenerate.GetLength(0); i++)
    {
        for (var j = 0; j < MatrixToGenerate.GetLength(1); j++)
        {
            MatrixToGenerate[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintHeaderOfMatrix(int lenght, string name = "")
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

void PrintMatrix(int[,] arrayToPrint, string name = "")
{
    PrintHeaderOfMatrix(arrayToPrint.GetLength(1), name);
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

void MultiplicationMatrix(int[,] matrix1, int[,] matrix2, int[,] productMultiplication)
{
    for (var i = 0; i < matrix1.GetLength(0); i++)
    {
        for (var j = 0; j < matrix2.GetLength(1); j++)
        {
            for (var k = 0; k <= matrix2.GetLength(1); k++)
            {
                productMultiplication[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
}

int[,] matrixOne = new int[2, 3];
int[,] matrixTwo = new int[3, 2];
int[,] multMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

GenerateMatrix(matrixOne);

PrintMatrix(matrixOne, "Первая матрица");

GenerateMatrix(matrixTwo);

PrintMatrix(matrixTwo, "Вторая матрица");

if (matrixOne.GetLength(0) == matrixTwo.GetLength(1))
{
    MultiplicationMatrix(matrixOne, matrixTwo, multMatrix);

    PrintMatrix(multMatrix, "Результат умножения");
}
else
{
    System.Console.WriteLine("---------------------------------------");
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine("Невозможно выполнить умножение матриц");
    System.Console.WriteLine("Матрицы не согласованы!");
}