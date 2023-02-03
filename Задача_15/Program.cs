// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,является ли этот день выходным.


Console.Clear();
Console.WriteLine("Введите цифру дня недели");

int x = int.Parse(Console.ReadLine()!);

if (x > 0 && x  <= 5)
{
    Console.WriteLine("Это рабочий день");
}
else if (x > 5 && x <=7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}