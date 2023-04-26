using System;
using System.Collections.Generic;

Stack<char> stack = new Stack<char>();
List<char> postfixExpression = new List<char>();
string expression = Console.ReadLine();
for (int i = 0; i < expression.Length; i++)
{
    char c = expression[i];
    if (c == '0' || c == '1')
    {
        postfixExpression.Add(c);
        continue;
    }

    if (c == '(') stack.Push(c);
    else if (c == ')')
    {
        char pop = stack.Pop();
        while (pop != '(')
        {
            postfixExpression.Add(pop);
            if (stack.Count == 0) break;
            pop = stack.Pop();
        }
    }
    else if (c == '!')
    {
        if (stack.Count == 0) stack.Push(c);
        else
        {
            char peek = stack.Peek();
            while (peek == '!')
            {
                postfixExpression.Add(stack.Pop());
                if (stack.Count == 0) break;
                peek = stack.Peek();
            }
            stack.Push('!');
        }
    }
    else if (c == '&')
    {
        if (stack.Count == 0) stack.Push(c);
        else
        {
            char peek = stack.Peek();
            while (peek == '&' || peek == '!')
            {
                postfixExpression.Add(stack.Pop());
                if (stack.Count == 0) break;
                peek = stack.Peek();
            }
            stack.Push('&');
        }
    }
    else if (c == '|' || c == '^')
    {
        if (stack.Count == 0) stack.Push(c);
        else
        {
            char peek = stack.Peek();
            while (peek == '|' || peek == '&' || peek == '!' || peek == '^')
            {
                postfixExpression.Add(stack.Pop());
                if (stack.Count == 0) break;
                peek = stack.Peek();
            }
            stack.Push(c);
        }
    }
}

while (stack.Count != 0) postfixExpression.Add(stack.Pop());

for (int i = 0; i < postfixExpression.Count; i++)
{
    char c = postfixExpression[i];
    if (c == '0' || c == '1') stack.Push(c);
    else
    {
        char number1 = stack.Pop();
        if (c == '!') stack.Push(number1 == '1' ? '0' : '1');
        else
        {
            char number2 = stack.Pop();
            if(c == '&')
            {
                if (number1 == '1' && number2 == '1') stack.Push('1');
                else stack.Push('0');
            }
            else if(c == '|')
            {
                if (number1 == '0' && number2 == '0') stack.Push('0');
                else stack.Push('1');
            }
            else if(c == '^')
            {
                if (number1 == '0' && number2 == '0' || number1 == '1' && number2 == '1') stack.Push('0');
                else stack.Push('1');
            }
        }
    }
}

Console.WriteLine(stack.Pop());