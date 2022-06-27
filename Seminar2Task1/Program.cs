//Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int digitOne = number / 100;
// int digitThree = number % 10;
// Console.WriteLine("результат " + digitOne + digitThree);

// int result = digitOne * 10 + digitThree * 1;
// Console.WriteLine(result);

int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int SearchResult(int number)
{
    int first = number / 100; // 456 -> 4
    int third = number % 10; // 456 -> 6
    return first * 10 + third * 1;
}
Console.WriteLine(SearchResult(number));