/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

Console.Write("Введите координаты точки X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y: ");
int Y = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки X1: ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y1: ");
int Y1 = int.Parse(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(X1 - X, 2) + Math.Pow(Y1 - Y, 2));  // Math.Pow - возведение в квадрат
Console.Write($"Расстояние между двумя точками на плоскости равно {dist:f3}"); // :f3 - количество цифр после запятой
