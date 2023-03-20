using System;
using System.Collections.Generic;

int k = int.Parse(Console.ReadLine());
string word = Console.ReadLine();

int max = 0;
HashSet<char> chars = new HashSet<char>(word.ToCharArray());
foreach(char c in chars)
{
    int start = 0, end = 0;
    int replacement = 0;
    while (end < word.Length)
    {
        if (c != word[end]) replacement++;

        while(replacement > k)
        {
            if (word[start] != c) replacement--;
            start++;
        }

        max = Math.Max(max, end - start + 1);
        end++;
    }
}

Console.WriteLine(max);