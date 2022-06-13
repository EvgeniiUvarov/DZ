using System;
Console.Clear();

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.Write("max: = ");
Console.WriteLine(max); 

Console.Write("min: ");
Console.WriteLine(min);



