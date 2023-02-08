// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!);
int res = 1;

for (int i = 1; i <= n; i++)
{
    res = res * i;

}

Console.WriteLine($"={res}");
