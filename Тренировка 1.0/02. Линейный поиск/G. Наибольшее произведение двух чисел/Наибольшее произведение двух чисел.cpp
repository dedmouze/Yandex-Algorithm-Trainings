#include <iostream>
#include <vector>
#include <string>
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

    int max1, max2, min1, min2;
    if (numbers[0] >= numbers[1])
    {
        max1 = numbers[0];
        max2 = numbers[1];
    }
    else
    {
        max1 = numbers[1];
        max2 = numbers[0];
    }
    min1 = max2;
    min2 = max1;

    for (int i = 2, n = numbers.size(); i < n; i++)
    {
        int number = numbers[i];
        if (number >= 0)
        {
            if (number > max1)
            {
                max2 = max1;
                max1 = number;
            }
            else if (number > max2) max2 = number;
        }
        else
        {
            if (number < min1)
            {
                min2 = min1;
                min1 = number;
            }
            else if (number < min2) min2 = number;
        }
    }

    if ((long)max1 * max2 > (long)min1 * min2) cout << max2 << " " << max1;
    else cout << min1 << " " << min2;
}
