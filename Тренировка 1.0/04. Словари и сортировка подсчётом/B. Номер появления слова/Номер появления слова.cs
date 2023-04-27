using System;
using System.IO;
using System.Collections.Generic;

using (TextReader reader = File.OpenText("input.txt"))
{
    string[] words = reader.ReadToEnd().Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    Dictionary<string, int> map = new Dictionary<string, int>();
    for (int i = 0; i < words.Length; i++)
    {
        string word = words[i];
        if (!map.ContainsKey(word))
        {
            map[word] = 0;
            Console.Write(0 + " ");
        }
        else
        {
            map[word]++;
            Console.Write(map[word] + " ");
        }
    }
}