// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Write("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Четверть 1");
} 
if (X < 0 && Y > 0)
{
    Console.WriteLine("Четверть 2");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("Четверть 3");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("Четверть 4");
}
if ((X == 0 && Y == 0) | (X == 0 && Y > 0) | (X == 0 && Y < 0) | (X > 0 && Y == 0) | (X < 0 && Y == 0))
{
    Console.WriteLine("X и Y не должны равняться 0");
}