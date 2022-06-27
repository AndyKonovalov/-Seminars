Console.Write("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number >= 100 && Number <= 999)
{
    Number = Number % 10;
    Console.WriteLine ("Последнее число " + Number);
}
else
{
    Console.WriteLine ("Error");
}