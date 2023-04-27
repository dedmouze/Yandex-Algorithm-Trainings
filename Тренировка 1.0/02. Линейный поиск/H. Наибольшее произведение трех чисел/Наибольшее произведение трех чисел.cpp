#include <iostream>
#include <string>
#include <vector>
#include <sstream>

using namespace std;

int main()
{
    vector<int> numbers;
    string input;
    getline(cin, input);
    stringstream ss(input);
    int number;
    while (ss >> number) numbers.push_back(number);

    int number1 = numbers[0], number2 = numbers[1], number3 = numbers[2];
    int max1, max2, max3, min1, min2;

    if (number1 > number2 && number1 > number3)
    {
        max1 = number1;
        if (number2 > number3)
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
    else if (number2 > number1 && number2 > number3)
    {
        max1 = number2;
        if (number1 > number3)
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

    for (int i = 3, n = numbers.size(); i < n; i++)
    {
        int number = numbers[i];

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

    if ((long)max1 * max2 * max3 > (long)max1 * min1 * min2) cout << max3 << " " << max2 << " " << max1;
    else cout << min1 << " " << min2 << " " << max1;
}