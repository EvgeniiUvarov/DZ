using System;
Console.Clear();

int N = Convert.ToInt32(Console.ReadLine());
int Curent = 0;

while (Curent <= N)
{
    if (Curent % 2 == 0)
    {
     Console.Write(Curent);
     Console.Write(", ");
    }
    Curent ++;
}
Console.WriteLine("Finish");