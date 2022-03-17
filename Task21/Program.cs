// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x1-x2) * (x1-x2) + (y1-y2) * (y1-y2) + (z1-z2) * (z1-z2));
result = Math.Round(result, 2);

Console.WriteLine("Расстояние между двумя точками: " + result);