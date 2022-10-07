﻿Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
  double x = (b2-b1)/(k1-k2);
  double y = k1 * x + b1;
  Console.WriteLine($"Прямые пересекаются в точке с координатами ({x:f2}, {y:f2})");
}
else if (k1 == k2 && b1 == b2)
{
  Console.WriteLine("Прямые совпадают");
}
else
{
  Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
}