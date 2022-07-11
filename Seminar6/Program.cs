// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// Console.Write("Set the size of the array: ");
// string number = Console.ReadLine();

// if (int.TryParse(number, out int size) && (size > 0))
// {
//     int[] array = new int[size];
//     int lastIndex = size - 1;
//     int[] reverseArray = new int[array.Length];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(11);
//     }
//     Console.WriteLine($"Start array [{String.Join("; ", array)}]");

//     for (int i = 0; i < array.Length; i++)
//     {
//         reverseArray[i] = array[array.Length - 1 - i];
//     }

//     Console.WriteLine($"Start array [{String.Join("; ", reverseArray)}]");
// }
// else
// {
//     Console.WriteLine("Error");
// }

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray = ReverseCopyArray(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReverseArray(array);
// Console.WriteLine(String.Join(" ", array));

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1); // Next(0,11) -> [0;10]
//     }
//     return res;
// }

// void ReverseArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int temp = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = temp;
//     }
// }

// int[] ReverseCopyArray(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];

//     }
//     return result;
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// int firstNumber = Convert.ToInt32(Console.ReadLine());
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// if ((firstNumber < secondNumber + thirdNumber) && (secondNumber < firstNumber + thirdNumber) && (thirdNumber < firstNumber + secondNumber))
// {
//     Console.WriteLine("Треугольник со сторонами такой длины может существовать");
// }
// else
// {
//     Console.WriteLine("Треугольник со сторонами такой длины не может существовать");
// }

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int N = 10;
// int firstElement = 0;
// int secondElement = 1;
// Console.WriteLine(firstElement);
// Console.WriteLine(secondElement);

// for (int i = 3; i <= N; i++)
// {
//     int nextElement = firstElement + secondElement;
//     Console.WriteLine(nextElement);
//     firstElement = secondElement;
//     secondElement = nextElement;
// }

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// void Binary(int number)
// {
// string errorResult = "";
// string result = "";
// while(number>0)
// {
// result = number%2 + result;
// errorResult = errorResult + number%2 ;
// number/=2;
// }
// Console.WriteLine(result);
// Console.WriteLine("Неправильный результат: "+ errorResult);

// }

// int inputNumber = Convert.ToInt32(Console.ReadLine());
// Binary(inputNumber);
