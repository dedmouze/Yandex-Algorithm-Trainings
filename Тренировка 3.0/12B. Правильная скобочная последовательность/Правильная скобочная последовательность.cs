using System;
using System.Collections.Generic;

string input = Console.ReadLine();
Stack<char> stack = new Stack<char>();
for(int i = 0; i < input.Length; i++)
{
    char c = input[i];
    if (c == '(' || c == '{' || c == '[') stack.Push(c);
    else
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("no");
            return;
        }

        char top = stack.Peek();
        if (top == '(' && c == ')' || top == '[' && c == ']' || top == '{' && c == '}') stack.Pop();
        else
        {
            Console.WriteLine("no");
            return;
        }
    }
}

Console.WriteLine(stack.Count == 0 ? "yes" : "no");
