using System;

short N = short.Parse(Console.ReadLine());
string[] numbers = Console.ReadLine().Split(' ');
short x = short.Parse(Console.ReadLine());

short closest = short.Parse(numbers[0]);
for(int i = 1; i < N; i++)
{
    short number = short.Parse(numbers[i]);
    if (number == x)
    {
        closest = number;
        break;
    }
    else if (Math.Abs(closest - x) > Math.Abs(number - x)) closest = number;
}

Console.WriteLine(closest);