using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
Dictionary<string, string> map = new Dictionary<string, string>();
for(int i = 0; i < N; i++)
{
    string[] synonyms = Console.ReadLine().Split(' ');
    if (!map.ContainsKey(synonyms[0])) map.Add(synonyms[0], synonyms[1]);
    if (!map.ContainsKey(synonyms[1])) map.Add(synonyms[1], synonyms[0]);
}

Console.WriteLine(map[Console.ReadLine()]);