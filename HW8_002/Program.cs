// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

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
int[] SumByRow(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumByRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumByRow += array[i, j];
        }
        sum[i] = sumByRow;  
    }
    return sum;

}
int RowWithMinSum(int[] sums)
{
    int minIndex = 0;
    for (int i = 1; i < sums.Length; i++)
    {
        if (sums[i] < sums[minIndex])
        {
            minIndex = i;
        }
    }
    return minIndex;
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
void PrintArrayOne(int[] array)
{
    Console.WriteLine($"{array[0]} ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void Runner()
{
     int rows = Prompt("Введите количество строк ");
    int columns = Prompt("Введите количество столбцов ");
    int lowLim = Prompt("Введите минимальное значение в массиве");
    int upperLim = Prompt("Введите максимальное значение в массиве");
    int[,] array = CreateArray(rows, columns, lowLim, upperLim);
    PrintArray(array);
    Console.WriteLine();
    int[] sumByRow = SumByRow(array);
    PrintArrayOne(sumByRow);
    int minSumRow = RowWithMinSum(sumByRow);
    Console.WriteLine();
    Console.Write($"строка с наименьшей суммой {minSumRow}");
}
Runner();