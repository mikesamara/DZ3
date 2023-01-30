// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
System.Console.WriteLine("Введите координаты первой точки");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки");
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());
double distance;
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками равно {distance}");
                