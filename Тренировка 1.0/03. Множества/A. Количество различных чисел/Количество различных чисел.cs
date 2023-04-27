using System;
using System.Collections.Generic;

HashSet<int> set = new HashSet<int>();
string[] numbers = Console.ReadLine().Split(' ');
for (int i = 0; i < numbers.Length; i++) set.Add(int.Parse(numbers[i]));

Console.WriteLine(set.Count);