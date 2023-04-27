using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());

HashSet<int> set = new HashSet<int>();
for(int i = 0; i < N; i++)
{
    string[] turtle = Console.ReadLine().Split(' ');
    int ai = int.Parse(turtle[0]);
    int bi = int.Parse(turtle[1]);
    if (ai >= 0 && bi >= 0 && ai + bi == N - 1) set.Add(bi);
}

Console.WriteLine(set.Count);