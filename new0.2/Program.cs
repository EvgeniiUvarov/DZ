using System;
Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) 
{
    Console.Write("Число чётное: ");
    Console.WriteLine(number);
}
else 
{
    Console.Write("Число не чётное: ");
    Console.WriteLine(number);
}