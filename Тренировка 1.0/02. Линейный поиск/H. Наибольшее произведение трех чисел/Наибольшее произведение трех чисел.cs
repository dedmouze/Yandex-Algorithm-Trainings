using System;

string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

int number1 = int.Parse(numbers[0]), number2 = int.Parse(numbers[1]), number3 = int.Parse(numbers[2]);
int max1, max2, max3, min1, min2;

if(number1 > number2 && number1 > number3)
{
    max1 = number1;
    if(number2 > number3)
    {
        max2 = number2;
        max3 = number3;
    }
    else
    {
        max2 = number3;
        max3 = number2;
    }
}
else if(number2 > number1 && number2 > number3)
{
    max1 = number2;
    if(number1 > number3)
    {
        max2 = number1;
        max3 = number3;
    }
    else
    {
        max2 = number3;
        max3 = number1;
    }
}
else
{
    max1 = number3;
    if (number1 > number2)
    {
        max2 = number1;
        max3 = number2;
    }
    else
    {
        max2 = number2;
        max3 = number1;
    }
}

min1 = max3;
min2 = max2;

for(int i = 3; i < numbers.Length; i++)
{
    int number = int.Parse(numbers[i]);

    if (number > max1)
    {
        max3 = max2;
        max2 = max1;
        max1 = number;
    }
    else if (number > max2)
    {
        max3 = max2;
        max2 = number;
    }
    else if (number > max3) max3 = number;

    if (number < min1)
    {
        min2 = min1;
        min1 = number;
    }
    else if (number < min2) min2 = number;
}

if ((long)max1 * max2 * max3 > (long)max1 * min1 * min2) Console.WriteLine(max3 + " " + max2 + " " + max1);
else Console.WriteLine(min1 + " " + min2 + " " + max1);