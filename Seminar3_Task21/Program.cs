// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
Console.Write("Введите первую координату точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату точки В: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки В: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2)); // Math.Sqrt() -квадратный корень, Math.Pow(x1 - x2,2) - возведение во 2-ю степень

Console.WriteLine($"Расстояние между точками A и B равно: {Math.Round(dist)}"); // Math.Round() - округляет значение аргумента до целых