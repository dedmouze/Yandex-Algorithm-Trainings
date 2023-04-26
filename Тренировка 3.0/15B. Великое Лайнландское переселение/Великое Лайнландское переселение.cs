using System;
using System.Collections.Generic;

int N = int.Parse(Console.ReadLine());
string[] towns = Console.ReadLine().Split(' ');
Stack<(int, int)> stack = new Stack<(int, int)>();
int[] answer = new int[N];
stack.Push((int.Parse(towns[0]), 0));
for(int i = 1; i < N; i++)
{
    int town = int.Parse(towns[i]);
    (int, int) peek = stack.Peek();
    if (town < peek.Item1)
    {
        while(stack.Count != 0)
        {
            if (town >= stack.Peek().Item1) break;
            (int, int) pop = stack.Pop();
            answer[pop.Item2] = i;
        }
    }

    stack.Push((town, i));
}

while(stack.Count != 0)
{
    (int, int) pop = stack.Pop();
    answer[pop.Item2] = -1;
}

for (int i = 0; i < N; i++) Console.Write(answer[i] + " ");