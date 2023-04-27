using System;
using System.IO;
using System.Collections.Generic;

using(TextReader reader = File.OpenText("input.txt"))
{
    HashSet<string> uniqueWords = new HashSet<string>();
    string text = reader.ReadToEnd();
    string[] words = text.Split(new char[] {' ', '\n', '\r'} , StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < words.Length; i++) uniqueWords.Add(words[i]);
    Console.WriteLine(uniqueWords.Count);
}