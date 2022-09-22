/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/

Console.WriteLine("Введите координаты точки X:  ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y:  ");
int y = int.Parse(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("Данные координаты принадлежат первой четверти");
}
else if (x<0 && y>0)
{
    Console.WriteLine("Данные координаты принадлежат второй четверти");
}
else if (x<0 && y<0)
{
    Console.WriteLine("Данные координаты принадлежат третьей четверти");
}
else if (x>0 && y<0)
{
    Console.WriteLine("Данные координаты принадлежат четвертой четверти");
}
else 
{
    Console.WriteLine("Вы в начале координат");
}