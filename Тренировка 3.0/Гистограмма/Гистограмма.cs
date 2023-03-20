using System;
using System.IO;
using System.Collections.Generic;

int maxSymbols = 0;
SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
using (TextReader reader = File.OpenText("input.txt"))
{
    string text = reader.ReadToEnd();
    for (int i = 0; i < text.Length; i++)
    {
        char c = text[i];
        if (c == ' ' || c == '\n' || c == '\r') continue;

        if (!dict.ContainsKey(c)) dict.Add(c, 0);
        dict[c]++;

        maxSymbols = Math.Max(maxSymbols, dict[c]);
    }
}
var sortedKeys = dict.Keys;
for(int i = maxSymbols; i > 0; i--)
{
    foreach(var key in sortedKeys)
    {
        if (dict[key] >= i) Console.Write('#');
        else Console.Write(' ');
    }
    Console.Write('\n');
}

foreach (var key in sortedKeys) Console.Write(key);