// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("введите чиcло");
int number = int.Parse(Console.ReadLine());

if(number < 100 )
    {
        System.Console.WriteLine("третьей цифры нет ");
    }
while(number > 1000)
{
    number /= 10;
}
if(number > 100)
    {
     number = number % 10;
     System.Console.WriteLine($"третья цифра {number}");
    }
    