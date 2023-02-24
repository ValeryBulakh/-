// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }

}

void FindNumber(int[,] inArray)
{
    int minSumRowIndex = 0; 
    int minSumRow = int.MaxValue; 
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
         rowSum += inArray[i, j];
        }
            if (rowSum < minSumRow)
            {
                minSumRow = rowSum; 
                minSumRowIndex = i; 
            }
    }
        Console.WriteLine("строка с наименьшей суммой элементов: " + (minSumRowIndex + 1));
            
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, 0, 5);

PrintArray(array2D);
Console.WriteLine();
FindNumber(array2D);

