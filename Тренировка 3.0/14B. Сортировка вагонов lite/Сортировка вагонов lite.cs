using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
string[] wagons = Console.ReadLine().Split(' ');

int i = 0, needed = 1;
Stack<int> stack = new Stack<int>();
while (i < N || (stack.Count != 0 && stack.Peek() == needed))
{
    if(stack.Count != 0 && stack.Peek() == needed)
    {
        stack.Pop();
        needed++;
    }
    else stack.Push(int.Parse(wagons[i++]));
}

Console.WriteLine(needed == N + 1 ? "YES" : "NO");