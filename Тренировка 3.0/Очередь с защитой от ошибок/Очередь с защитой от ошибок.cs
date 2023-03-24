using System;
using System.Collections.Generic;

Queue<int> queue = new Queue<int>();
string input;
while (true)
{
    input = Console.ReadLine();
    string[] instruction = input.Split(' ');
    if(instruction.Length == 2)
    {
        queue.Enqueue(int.Parse(instruction[1]));
        Console.WriteLine("ok");
    }
    else
    {
        if (instruction[0] == "pop")
        {
            if (queue.Count > 0) Console.WriteLine(queue.Dequeue());
            else Console.WriteLine("error");
        }
        else if (instruction[0] == "front")
        {
            if (queue.Count > 0) Console.WriteLine(queue.Peek());
            else Console.WriteLine("error");
        }
        else if (instruction[0] == "size") Console.WriteLine(queue.Count);
        else if (instruction[0] == "clear")
        {
            Console.WriteLine("ok");
            queue.Clear();
        }
        else if (instruction[0] == "exit")
        {
            Console.WriteLine("bye");
            break;
        }
    }
}
