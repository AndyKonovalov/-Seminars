//Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.Write("Введите первое число: ");
int thirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (thirstNumber % secondNumber == 0)
{
    Console.WriteLine($"Второе число {secondNumber} кратно первому {thirstNumber}");
}
else
{
    Console.WriteLine($"Не кратно, остаток {thirstNumber % secondNumber}");
}