/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.WriteLine("Введите координаты х точки А : ");
int[] coordsA = new int [3];
coordsA[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты у точки A : ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
coordsA[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты х точки В: ");
int[] coordsB = new int[3];
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты у точки В: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
coordsB[2] = Convert.ToInt32(Console.ReadLine());
int distanceX = (int)Math.Pow(coordsB[0] - coordsA[0],3);
int distanceY = (int)Math.Pow(coordsB[1] - coordsA[1],3);
int distanceС = (int)Math.Pow(coordsB[2] - coordsA[2],3);

double Result = Math.Sqrt(distanceX + distanceY + distanceС);
System.Console.WriteLine(Math.Round(Result,3));
