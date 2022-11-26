// Задача 1: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
int[,] ChangeDigit(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = j;
            for (k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    (array[i, k], array[i, k + 1]) = (array[i, k + 1], array[i, k]);
                }

            }
        }
    }
    return array;

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

void Runner()
{
    int rows = Prompt("Введите количество строк ");
    int columns = Prompt("Введите количество столбцов ");
    int lowLim = Prompt("Введите минимальное значение в массиве");
    int upperLim = Prompt("Введите максимальное значение в массиве");
    int[,] array = CreateArray(rows, columns, lowLim, upperLim);
    System.Console.WriteLine();
    PrintArray(array);
    int[,] changedArray = ChangeDigit(array);
    PrintArray(changedArray);
}
Runner();
