// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти


Console.WriteLine("Введи четверть: ");
int number = int.Parse(Console.ReadLine());

switch(number){
    case 1:
    {
       Console.WriteLine("Диапазон возможных значений четверти x > 0, y > 0");
       break;
    }
    case 2:
    {
       Console.WriteLine("Диапазон возможных значений четверти x < 0, y > 0");
       break;
    }
    case 3:
    {
       Console.WriteLine("Диапазон возможных значений четверти x < 0, y < 0");
       break;
    }
    case 4:
    {
       Console.WriteLine("Диапазон возможных значений четверти x > 0, y < 0");
       break;
    }
}
