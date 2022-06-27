Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//    Console.WriteLine("Да, кратно");
// }
// else
// {
//    Console.WriteLine("Нет, не кратно");
// }
bool IsMultiplicity (int number) // bool - логическая функция, которая возвращает true либо false
{
    return (number % 7 == 0 && number % 23 == 0); // && - логическое 'И'
}
Console.WriteLine(IsMultiplicity(number));