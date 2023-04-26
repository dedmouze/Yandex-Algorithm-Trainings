using System;
using System.Collections;
using System.Collections.Generic;

string[] input = Console.ReadLine().Split(' ');
int N = int.Parse(input[0]);

long maxArea = 0;
Stack<(int, int)> stack = new Stack<(int, int)>();
stack.Push((0, -1));
for(int i = 1; i < N + 2; i++)
{
    int rectangle;
    if (i == input.Length) rectangle = 0;
    else rectangle = int.Parse(input[i]);

    int index = i;
    while (rectangle <= stack.Peek().Item2)
    {
        index = stack.Peek().Item1;
        maxArea = Math.Max(maxArea, (long)stack.Peek().Item2 * (i - index));
        stack.Pop();
    }

    stack.Push((index, rectangle));
}

Console.WriteLine(maxArea);