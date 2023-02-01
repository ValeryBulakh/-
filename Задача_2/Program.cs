//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");