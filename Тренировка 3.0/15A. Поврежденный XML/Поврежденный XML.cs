using System;
using System.Collections.Generic;

string input = Console.ReadLine();
char[] inputArr = input.ToCharArray();
string chars = "</>";
for (char c = 'a'; c <= 'z'; c++) chars += c;

for(int i = 0; i < inputArr.Length; i++)
{
    char ci = inputArr[i];
    for(int j = 0; j < chars.Length; j++)
    {
        char cj = chars[j];
        if (ci != cj)
        {
            inputArr[i] = cj;
            if(Check(inputArr))
            {
                Console.WriteLine(new string(inputArr));
                return;
            }
        }
    }
    inputArr[i] = ci;
}

bool Check(char[] line)
{
    if (line[0] != '<' || line[line.Length - 1] != '>') return false;

    int i = 0;
    Stack<string> stack = new Stack<string>();
    while (i != line.Length)
    {
        if (line[i] != '<') return false;
        i++;
        bool closing = false;
        if (line[i] == '/')
        {
            closing = true;
            i++;
        }
        if (!(line[i] >= 'a' && line[i] <= 'z')) return false;

        string t = "";
        while (line[i] >= 'a' && line[i] <= 'z')
        {
            t += line[i];
            i++;
        }

        if (line[i] != '>') return false;
        i++;

        if (!closing) stack.Push(t);
        else if (stack.Count == 0) return false;
        else if (stack.Peek() != t) return false;
        else stack.Pop();
    }

    return stack.Count == 0;
}