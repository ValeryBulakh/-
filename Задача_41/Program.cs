// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Clear();
Console.Write("Введите количество чисел: ");

int M = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < M; i++)
{
    Console.Write("Введите число: ");

    int number = int.Parse(Console.ReadLine());

    if (number > 0)
        count++;
}

Console.WriteLine($"Количество положительных чисел: {count}");
