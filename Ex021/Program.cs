﻿Console.Clear();
Console.Write("Введите координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Расстояние между точками: " + Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2)));

