using System;
Console.Clear();

Console.WriteLine("введите число: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

//if (a > max) max=a; (по идеи не нужен так как мы уже "a" сделали "max" )
if (b > max) max=b;
if (c > max) max=c;

Console.Write("max = ");
Console.WriteLine(max);

