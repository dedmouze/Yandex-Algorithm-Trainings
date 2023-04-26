using System;
using System.Collections.Generic;

List<int> stack = new List<int>();
string input;
while(true)
{
    input = Console.ReadLine();
    string[] instruction = input.Split(' ');
    if (instruction.Length == 2)
    {
        Console.WriteLine("ok");
        stack.Add(int.Parse(instruction[1]));
    }
    else
    {
        if (instruction[0] == "pop")
        {
            if (stack.Count > 0)
            {
                Console.WriteLine(stack[stack.Count - 1]);
                stack.RemoveAt(stack.Count - 1);
            }
            else Console.WriteLine("error");
        }
        else if (instruction[0] == "back")
        {
            if (stack.Count > 0) Console.WriteLine(stack[stack.Count - 1]);
            else Console.WriteLine("error");
        }
        else if (instruction[0] == "size") Console.WriteLine(stack.Count);
        else if (instruction[0] == "clear")
        {
            Console.WriteLine("ok");
            stack.Clear();
        }
        else if (instruction[0] == "exit")
        {
            Console.WriteLine("bye");
            break;
        }
    }
}
