using System;
using System.Collections.Generic;

List<int> list = new List<int>();
while(true)
{
    string input = Console.ReadLine();
    if (input == "-2000000000") break;
    list.Add(int.Parse(input));
}

bool constant, ascending, descending, weaklyAscending, weaklyDescending;
constant = ascending = descending = weaklyAscending = weaklyDescending = true;
for(int i = 1; i < list.Count; i++)
{
    if (constant && list[i] != list[i - 1]) constant = false;
    if (ascending && list[i] <= list[i - 1]) ascending = false;
    if (descending && list[i] >= list[i - 1]) descending = false;
    if (weaklyAscending && list[i] < list[i - 1]) weaklyAscending = false;
    if (weaklyDescending && list[i] > list[i - 1]) weaklyDescending = false;
}

if (constant) Console.WriteLine("CONSTANT");
else if (ascending) Console.WriteLine("ASCENDING");
else if (descending) Console.WriteLine("DESCENDING");
else if (weaklyAscending) Console.WriteLine("WEAKLY ASCENDING");
else if (weaklyDescending) Console.WriteLine("WEAKLY DESCENDING");
else Console.WriteLine("RANDOM");