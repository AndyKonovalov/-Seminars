﻿// Код для создания массива из рандомных чисел в диапазаоне от -9 до 9
// и поиска суммы отрицательных и положительных элементов массива
// int[] array = new int[12];

// int size = array.Length;

// int resultPositive = 0;

// int resultNegative = 0;

// int index = 0;

// while (index < size) 
// {
//     array[index] = new Random().Next(-9,10); // [-9;10)
//     index++;
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");
// for (int startIndex = 0; startIndex < size; startIndex++)
// {
//     if (array[startIndex] > 0) 
//     {
//         resultPositive += array[startIndex];
//         //resultPositive=resultPositive +  array[startIndex]
//     }
//     else 
//     {
//         resultNegative += array[startIndex];
//     }
// }
// // Console.WriteLine($"Сумма положительных чисел = {resultPositive}");
// // Console.WriteLine($"Сумма отрицательных чисел = {resultNegative}");

// int[] array = { -4, -8, 8, 2 };
// for (int i = 0; i < array.Length; i++)
// {
//     array [i] = array[i] * -1;
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");

// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// bool flagResult = false;
// int firstNum = 56;
// int[] array = {6, 7, 19, 345, 3};
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == firstNum)
//     {
//         flagResult = true;
//         break;
//     }
//     else 
//     {
//         flagResult = false;
//     }    
// }  
// if (flagResult == true)
// {
//     Console.WriteLine("+");
// }
// else
// {
//     Console.WriteLine("-");
// }
// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[123]; // [123]

// int size = array.Length;
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 125); // [0, 125)

// //for (int j = 0; j < array.Length; j++) 

//     if (array[i] >= 10 && array[i] <= 99) // от 10 до 99
//     {
//         count++;
//     }
// }
// Console.WriteLine($"В данном массиве [{String.Join("; ", array)}] количество элементов, лежащих в отрезке [10, 99] = {count}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sizeIsOdd = size / 2;
bool isArrayLengthOdd = size % 2 == 0 ? false : true;
int newSize = sizeIsOdd + Convert.ToInt32(isArrayLengthOdd);
int[] product = new int[newSize];
int rightBorder = size - 1;
int leftBorder = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(21);
}
Console.WriteLine($"Исходный массив [{String.Join("; ", array)}]");

for (int index = 0; index < sizeIsOdd; index++)
{
    product[index] = array[leftBorder] * array[rightBorder];
    leftBorder++;
    rightBorder--;
    if (isArrayLengthOdd)
    {
        product[sizeIsOdd] = array[sizeIsOdd];
    }
}
Console.WriteLine($"Новый массив [{String.Join("; ", product)}]");