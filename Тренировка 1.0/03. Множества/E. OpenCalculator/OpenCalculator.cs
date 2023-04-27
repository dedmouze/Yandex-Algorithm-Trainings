using System;
using System.Collections.Generic;

string[] xyz = Console.ReadLine().Split(' ');

HashSet<int> set1 = new HashSet<int>() { int.Parse(xyz[0]), int.Parse(xyz[1]), int.Parse(xyz[2]) };
HashSet<int> set2 = new HashSet<int>();
int number = int.Parse(Console.ReadLine());
while(number != 0)
{
    set2.Add(number % 10);
    number /= 10;
}

set2.ExceptWith(set1);

Console.WriteLine(set2.Count);