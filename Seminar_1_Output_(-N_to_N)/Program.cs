// Написать программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()); // тип данных "int" указывается при вводе данных, 
//в действиях, условии и цикле тип переменной не казывается

int negativeN = N * (-1); // N со знаком минус

while (negativeN <= N)
{
    Console.Write(negativeN + ";");
    negativeN = negativeN + 1; // nefativeN++ or negativeN +=1
}