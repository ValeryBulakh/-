// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
int row = new Random().Next(1, 5); ;
int col = new Random().Next(1, 5); ;
int[,] array = new int[row, col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        array[i, j] = new Random().Next(1, 100);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
for (int p = 0; p < col; p++)
{
    double sum = 0;
    for (int k = 0; k < row; k++)
    {
        sum = sum + array[k, p];
    }
    double d = sum / row;
    Console.WriteLine($"Среднее арифметическое {p + 1} столбца = {d}");
}