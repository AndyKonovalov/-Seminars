// написать программу, принимающую на вход число и выдающую его квадрат
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); // конвертируем строку в число, с помощью Convert.ToInt32 

int squareNumber = number * number;

Console.WriteLine ("Квадрат числа равен: " + squareNumber); // конкретинация склеивание

//Console.WriteLine(squareNumber); 