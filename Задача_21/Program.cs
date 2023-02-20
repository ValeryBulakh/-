//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

double matchX;
double matchY;
double matchZ;

Console.WriteLine("Введите х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите х2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2");
int z2 = Convert.ToInt32(Console.ReadLine());

matchX = Math.Pow(x1 - x2, 2);
matchY = Math.Pow(y1 - y2, 2);
matchZ = Math.Pow(z1 - z2, 2);

double mahch = Math.Sqrt(matchX + matchY + matchZ);
mahch = Math.Round(mahch, 2);
Console.WriteLine(mahch);
