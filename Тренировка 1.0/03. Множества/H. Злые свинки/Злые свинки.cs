using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());

HashSet<int> set = new HashSet<int>();
for(int i = 0; i < N; i++) set.Add(int.Parse(Console.ReadLine().Split(' ')[0]));
Console.WriteLine(set.Count);