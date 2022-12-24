// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using static System.Console;

Write("Точка A введите координату x: ");
int.TryParse(ReadLine(), out int ax);

Write("Точка A введите координату y: ");
int.TryParse(ReadLine(), out int ay);

Write("Точка A введите координату z: ");
int.TryParse(ReadLine(), out int az);

Write("Точка B введите координату x: ");
int.TryParse(ReadLine(), out int bx);

Write("Точка B введите координату y: ");
int.TryParse(ReadLine(), out int by);

Write("Точка B введите координату z: ");
int.TryParse(ReadLine(), out int bz);

double length = Math.Sqrt(Math.Pow((ax-bx), 2) + Math.Pow((ay-by), 2) + Math.Pow((az-bz), 2));
WriteLine($"{length:f2}");
