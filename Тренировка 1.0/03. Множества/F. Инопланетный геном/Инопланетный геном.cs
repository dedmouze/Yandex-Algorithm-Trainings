using System;
using System.Collections.Generic;

string gen1 = Console.ReadLine();
string gen2 = Console.ReadLine();

HashSet<string> set = new HashSet<string>();
for(int i = 0; i < gen2.Length - 1; i++) set.Add(gen2[i].ToString() + gen2[i + 1]);

int count = 0;
for(int i = 0; i < gen1.Length - 1; i++)
    if (set.Contains(gen1[i].ToString() + gen1[i + 1])) count++;

Console.WriteLine(count);
