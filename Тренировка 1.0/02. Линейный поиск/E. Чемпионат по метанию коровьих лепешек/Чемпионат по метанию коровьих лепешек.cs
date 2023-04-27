using System;

int n = int.Parse(Console.ReadLine());
string[] results = Console.ReadLine().Split(' ');

int bestThrowIndex = 0;
short bestThrow = short.Parse(results[0]);
for (int i = 1; i < n; i++)
{
    short number = short.Parse(results[i]);
    if (bestThrow < number)
    {
        bestThrow = number;
        bestThrowIndex = i;
    }
}

short vasyaThrow = -1;
for(int i = bestThrowIndex + 1; i < n - 1; i++)
{
    short throwResult = short.Parse(results[i]);
    if (throwResult % 10 == 5 && throwResult > short.Parse(results[i + 1]) && vasyaThrow < throwResult) vasyaThrow = throwResult;
}

if (vasyaThrow == -1) Console.WriteLine(0);
else
{
    int position = 1;
    for (int i = 0; i < n; i++)
        if (vasyaThrow < short.Parse(results[i])) position++;

    Console.WriteLine(position);
}