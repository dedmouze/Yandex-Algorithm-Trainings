using System;
using System.Collections.Generic;

string[] array1 = Console.ReadLine().Split(' ');
string[] array2 = Console.ReadLine().Split(' ');

HashSet<int> set = new HashSet<int>();
for (int i = 0; i < array1.Length; i++) set.Add(int.Parse(array1[i]));

List<int> intersect = new List<int>();
for(int i = 0; i < array2.Length; i++)
{
    int number = int.Parse(array2[i]);
    if (set.Contains(number)) intersect.Add(number);
}

intersect.Sort();
for (int i = 0; i < intersect.Count; i++) Console.Write(intersect[i] + " ");