// Написать программу, которая из рандомного набора чисел, 
// выбирает число и выводит в консоль наибольшую цифру числа
int number = new Random().Next(10, 100); // [10, 99)
Console.WriteLine ($"Значение: {number} "); // интерполяция
int digitOne = number / 10; // 56 -> 5
int digitTwo = number % 10; // 56 -> 6

Console.WriteLine(digitOne);
Console.WriteLine(digitTwo);

int max = Math.Max(digitOne, digitTwo); // Сравнивает значение в скобках и выдает максимальное
int min = Math.Min(digitOne, digitTwo); // Сравнивает значение в скобках и выдает минимальное
Console.WriteLine($"Самое максимальное число - это {max}");
Console.WriteLine($"Самое минимальное число - это {min}");