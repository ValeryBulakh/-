// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();

Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine()!);
int res = 0;
for (int i = 0; i < x; i++)
{
    res = i * i * i;

if (res % 2 == 0) ;
Console.WriteLine(res);
}