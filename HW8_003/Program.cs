// Задача 3: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateArray(int rows, int columns, int lowerLim, int upperLim)
{
    int[,] table = new int[rows, columns];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(lowerLim, upperLim);
        }
    }
    return table;
}

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }


    int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
    {
        int[,] multMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < multMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multMatrix.GetLength(1); j++)
            {
                multMatrix[i, j] = 0;
                for (int l = 0; l < matrix1.GetLength(1); l++)
                {
                    multMatrix[l, j] += matrix1[i, l] * matrix2[l, j];
                }
            }
        }
        return multMatrix;
    }
 void Runner()
 {
        int rows1 = Prompt("Введите количество строк matrix1");
        int columns1 = Prompt("Введите количество столбцов matrix1");
        int lowLim1 = Prompt("Введите минимальное значение в массиве matrix1");
        int upperLim1 = Prompt("Введите максимальное значение в массиве matrix1");
        int[,] matrix1 = CreateArray(rows1, columns1, lowLim1, upperLim1);
        int rows2 = Prompt("Введите количество строк matrix2");
        int columns2 = Prompt("Введите количество столбцов matrix2");
        int lowLim2 = Prompt("Введите минимальное значение в массиве matrix2");
        int upperLim2 = Prompt("Введите максимальное значение в массиве matrix2");
        int[,] matrix2 = CreateArray(rows2, columns2, lowLim2, upperLim2);
        PrintArray(matrix1);
        PrintArray(matrix2);
        Console.WriteLine();
        int[,] array = MatrixMultiplication(matrix1,matrix2);
        PrintArray(array);
 }
    Runner();