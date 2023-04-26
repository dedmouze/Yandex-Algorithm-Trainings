using System;
using System.Collections.Generic;

char prev = '\0';
char space = '\0';
string expression = Console.ReadLine();
string infixExpression = "";
Stack<char> brackets = new Stack<char>();
for (int j = 0; j < expression.Length; j++)
{
    char c = expression[j];
    if (Char.IsDigit(c) && space == ' ' && Char.IsDigit(prev))
    {
        Console.WriteLine("WRONG");
        return;
    }
    space = c;
    if (c == ' ') continue;

    if (!Char.IsDigit(c) && c != '(' && c != ')' && c != '+' && c != '-' && c != '*')
    {
        Console.WriteLine("WRONG");
        return;
    }

    if(prev == '\0' && (c == '*' || c == '+'))
    {
        Console.WriteLine("WRONG");
        return;
    }

    if(c == '(' && Char.IsDigit(prev))
    {
        Console.WriteLine("WRONG");
        return;
    }

    if (c == '(')
    {
        while (j != expression.Length - 1 && expression[j + 1] == ' ') j++;

        if (j != expression.Length - 1 && expression[j + 1] == '+' || expression[j + 1] == '*')
        {
            Console.WriteLine("WRONG");
            return;
        }

        brackets.Push('(');
    }
    else if (c == ')')
    {
        if (brackets.Count == 0)
        {
            Console.WriteLine("WRONG");
            return;
        }
        brackets.Pop();
    }

    if(c == '+' || c == '-' || c == '*')
    {
        while (j != expression.Length - 1 && expression[j + 1] == ' ') j++;

        if (j == expression.Length - 1 || j != expression.Length - 1 && !Char.IsDigit(expression[j + 1]) && expression[j + 1] != '(')
        {
            Console.WriteLine("WRONG");
            return;
        }
    }  


    infixExpression += c;
    prev = c;
}

if(brackets.Count != 0)
{
    Console.WriteLine("WRONG");
    return;
}

int i = 0;
string number = "";
List<string> postfixExpression = new List<string>();
Stack<string> stack = new Stack<string>();
while(i < infixExpression.Length)
{
    char c = infixExpression[i];

    if (i == 0 && c == '-' && Char.IsDigit(infixExpression[i + 1]))
    {
        number += '-';
        i++;
        continue;
    }
    if(c == '(' && infixExpression[i + 1] == '-' && Char.IsDigit(infixExpression[i + 2]))
    {
        number += '-';
        i++;
    }

    if (Char.IsDigit(c))
    {
        while (Char.IsDigit(c))
        {
            number += c;
            i++;
            if (i == infixExpression.Length) break;
            c = infixExpression[i];
        }

        postfixExpression.Add(number);
        number = "";
    }

    if (c == '(') stack.Push("(");
    else if (c == ')')
    {
        string pop = stack.Pop();
        while (pop != "(")
        {
            postfixExpression.Add(pop);
            if (stack.Count == 0) break;
            pop = stack.Pop();
        }
    }
    else if (c == '*') CheckPostfixOperations("*", postfixExpression, stack);
    else if (c == '+') CheckPostfixOperations("+", postfixExpression, stack);
    else if (c == '-') CheckPostfixOperations("-", postfixExpression, stack);

    i++;
}

while (stack.Count != 0) postfixExpression.Add(stack.Pop());

for (int j = 0; j < postfixExpression.Count; j++)
{
    if (Char.IsNumber(postfixExpression[j][0])) stack.Push(postfixExpression[j]);
    else
    {
        int number1 = int.Parse(stack.Pop());
        int number2 = int.Parse(stack.Pop());
        if (postfixExpression[j] == "+") stack.Push((number1 + number2).ToString());
        else if (postfixExpression[j] == "-") stack.Push((number2 - number1).ToString());
        else if (postfixExpression[j] == "*") stack.Push((number1 * number2).ToString());
    }
}

Console.WriteLine(stack.Pop());

void CheckPostfixOperations(string operation, List<string> postfixExpression, Stack<string> stack)
{
    string op1 = "";
    string op2 = "";
    switch(operation)
    {
        case "*": op1 = op2 = "*";
            break;
        case "+":
            op1 = "-";
            op2 = "*";
            break;
        case "-":
            op1 = "+";
            op2 = "*";
            break;
    }

    if (stack.Count == 0) stack.Push(operation);
    else
    {
        string peek = stack.Peek();
        while (peek == op1 || peek == op2)
        {
            postfixExpression.Add(stack.Pop());
            if (stack.Count == 0) break;
            peek = stack.Peek();
        }
        stack.Push(operation);
    }
}
