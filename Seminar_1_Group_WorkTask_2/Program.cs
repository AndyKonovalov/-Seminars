// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (1 <= dayNumber && dayNumber <= 7)
{
    if (dayNumber == 1)
    {
     Console.WriteLine (dayNumber + " Понедельник");
    }
    if (dayNumber == 2)
    {
     Console.WriteLine (dayNumber + " Вторник");
    }
    if (dayNumber == 3)
    {
     Console.WriteLine (dayNumber + " Среда");
    }
    if (dayNumber == 4)
    {
     Console.WriteLine (dayNumber + " Четверг");
    }
    if (dayNumber == 5)
    {
     Console.WriteLine (dayNumber + " Пятница");
    }
    if (dayNumber == 6)
    {
     Console.WriteLine (dayNumber + " Суббота");
    }
    if (dayNumber == 7)
    {
     Console.WriteLine (dayNumber + " Воскресенье");
    }
}
else 
{
    Console.WriteLine("Error");
}