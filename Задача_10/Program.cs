// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Clear();

Console.WriteLine("введите число");

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"вторая цифра {(number % 100 - (number % 100) % 10)/10}");