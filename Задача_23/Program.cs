// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

int count = 1;
Console.Write("введте число: ");
int a = Convert.ToInt32(Console.ReadLine());

while (count <= a)
{
    Console.Write(count * count * count);
    if (count != a)
    {
        Console.Write(", ");
    }
    count++;
}
