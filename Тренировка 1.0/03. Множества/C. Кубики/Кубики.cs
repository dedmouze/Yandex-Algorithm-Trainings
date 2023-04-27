using System;
using System.Collections.Generic;

void Print(List<int> list)
{
    Console.WriteLine(list.Count);
    for (int i = 0; i < list.Count; i++) Console.Write(list[i] + " ");
    Console.Write('\n');
}

string[] countOfCubes = Console.ReadLine().Split(' ');
int N = int.Parse(countOfCubes[0]);
int M = int.Parse(countOfCubes[1]);

SortedSet<int> set1 = new SortedSet<int>();
SortedSet<int> set2 = new SortedSet<int>();

for(int i = 0; i < N; i++) set1.Add(int.Parse(Console.ReadLine()));
for(int i = 0; i < M; i++) set2.Add(int.Parse(Console.ReadLine()));

List<int> notInAnn = new List<int>();
List<int> intersections = new List<int>();
foreach(int num in set1)
    if(set2.Contains(num)) intersections.Add(num);
    else notInAnn.Add(num);

List<int> notInBorya = new List<int>();
foreach (int num in set2)
    if (!set1.Contains(num)) notInBorya.Add(num);

Print(intersections);
Print(notInAnn);
Print(notInBorya);
