using System;
using System.IO;
using System.Collections.Generic;

using(TextReader reader = File.OpenText("input.txt"))
{
    string[] words = reader.ReadToEnd().Split(new char[] {' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

    int max = -1;
    string minKey = "";
    Dictionary<string, int> map = new Dictionary<string, int>();
    for(int i = 0; i < words.Length; i++)
    {
        if (!map.ContainsKey(words[i])) map.Add(words[i], 0);
        map[words[i]]++;

        if(max < map[words[i]])
        {
            max = map[words[i]];
            minKey = words[i];
        }
        else if(max == map[words[i]])
        {
            if (Compare(words[i], minKey)) minKey = words[i];
        }
    }

    Console.WriteLine(minKey);
}

bool Compare(string a, string b)
{
    int minLength = a.Length < b.Length ? a.Length : b.Length;
    for (int i = 0; i < minLength; i++)
        if (a[i] < b[i]) return true;
        else if (a[i] > b[i]) return false;

    if (a.Length < b.Length) return true;
    else return false;
}