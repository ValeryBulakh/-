// Подсчитать сумму цифр в числе

Console.Clear();

Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine()!);
int sum = 0;

while (x > 0)
{
    sum = sum + x % 10;
    x = x / 10;
}
Console.WriteLine(sum);
