Console.Write("Введите номер четверти ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 1 ^ number >= 5) // не позволит ввести 0 или больше 4
{
    Console.WriteLine("Вводимое число должно быть в диапозоне от 1 до 4");
}
if (number == 1)
{
    Console.WriteLine("X > 0 и Y > 0");
}
if (number == 2)
{
    Console.WriteLine("X < 0 и Y > 0");
}
if (number == 3)
{
    Console.WriteLine("X < 0 и Y < 0");
}
if (number == 4)
{
    Console.WriteLine("X > 0 и Y < 0");
}