using System;
using System.Collections.Generic;

string[] operations = Console.ReadLine().Split(' ');
Stack<string> stack = new Stack<string>();
for(int i = 0; i < operations.Length; i++)
{
    if (Char.IsNumber(operations[i][0])) stack.Push(operations[i]);
    else
    {
        int number1 = int.Parse(stack.Pop());
        int number2 = int.Parse(stack.Pop());
        if (operations[i] == "+") stack.Push((number1 + number2).ToString());
        else if (operations[i] == "-") stack.Push((number2 - number1).ToString());
        else if (operations[i] == "*") stack.Push((number1 * number2).ToString());
    }
}

Console.WriteLine(stack.Pop());