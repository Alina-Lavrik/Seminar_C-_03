/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.

2 -> 1,4
*/ 

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());

for (int index = 1; index <= number; index ++)
{
    double result = Math.Pow(index, 2);
    Console.Write($"{result} ");
}

