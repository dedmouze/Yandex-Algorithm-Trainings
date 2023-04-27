#include <iostream>

bool check(unsigned long middle, unsigned long long sum, unsigned long long count)
{
    sum += middle * 5;
    count += middle;
    
    return 2 * sum < 7 * count;
}

int main()
{
    unsigned long A, B, C;
    std::cin >> A >> B >> C;

    unsigned long sum = A * 2 + B * 3 + C * 4, count = A + B + C;
    unsigned long middle, left = 0, right = A * 2 + B + C;
    while (left != right)
    {
        middle = (left + right) / 2;
        if (check(middle, sum, count)) left = middle + 1;
        else right = middle;
    }

    std::cout << left;
}
