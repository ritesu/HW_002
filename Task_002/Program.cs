﻿Console.WriteLine("Введите координаты первой точки по x, y, z, соответственно");
double x1 = double.Parse(Console.ReadLine()?? "0");
double y1 = double.Parse(Console.ReadLine()?? "0");
double z1 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите координаты второй точки по x, y, z, соответственно");
double x2 = double.Parse(Console.ReadLine()?? "0");
double y2 = double.Parse(Console.ReadLine()?? "0");
double z2 = double.Parse(Console.ReadLine()?? "0");
double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между двумя точками равно");
Console.WriteLine(a);