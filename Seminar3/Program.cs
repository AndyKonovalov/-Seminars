// int [] array = {1, 2, 3, 4, 5};

// Console.WriteLine($"{String.Join("; ", array)}"); // выводит массив через консоль врайтлайн

//int index = 1;
//Console.WriteLine(index++); // пост-инкремент сначала печатает 1, потом увеличивает на 2
// Пре-инкремент, пост-инкремент
//Console.WriteLine(++index); // пре-инкремент выводит увеличенное на 1 значение

// string test = "12345"; // 12345
// int result = 0;
// Console.WriteLine(int.TryParse(test, out result)); // Проверяет если строка состоит из чисел выдает 'True'
// Console.WriteLine(result);

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Console.Write("Enter number: ");
// string number = Console.ReadLine();

// int numLength = number.Length;
// Console.WriteLine(numLength);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void Method(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(2);
//     }
//     Console.WriteLine($"{String.Join("; ", array)}");
// }
// Method(8);

// int [] array = new int [8]; //new Random.Next(0, 2);
// for(int i = 0; i<=8; i++)
// {
//     array[i] = new Random().Next(0,2); 
//     Console.WriteLine(array[i]);
// }

//Задача 28: Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.
// int N = Convert.ToInt32(Console.ReadLine());

// int result = 1;
// int start = 1;
// for (int i = start; i <= N; i++)
// {
//     result *= i;
// }
// Console.WriteLine(result);
// String str;
// char[] StrChar = Str.ToCharArray(); // и не важно числа или символы. Как раз таки массив символов создаётся
