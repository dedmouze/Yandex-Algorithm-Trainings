using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());

HashSet<string> allLanguages = new HashSet<string>();
Dictionary<string, int> languagesMap = new Dictionary<string, int>();
for(int i = 0; i < N; i++)
{
    int M = int.Parse(Console.ReadLine());
    for(int j = 0; j < M; j++)
    {
        string language = Console.ReadLine();
        if(!languagesMap.ContainsKey(language)) languagesMap.Add(language, 0);
        languagesMap[language]++;
        allLanguages.Add(language);
    }
}

int onlyCount = 0;
foreach (var pair in languagesMap)
    if (pair.Value == N) onlyCount++;

Console.WriteLine(onlyCount);
foreach (var pair in languagesMap)
    if(pair.Value == N) Console.WriteLine(pair.Key);

Console.WriteLine(allLanguages.Count);
foreach (string language in allLanguages) Console.WriteLine(language);