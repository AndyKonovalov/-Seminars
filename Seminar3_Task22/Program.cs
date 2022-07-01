// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1; // числа от 1 до N
int d = 0; // квадрат числа N

while (i <= N) // for(int i = 1; i <= N; i++) - цикл for позволяет компактнее записать цикл while
{
    d = i * i;
    Console.WriteLine(d);
    i++;
}