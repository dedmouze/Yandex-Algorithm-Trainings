#include <iostream>
#include <set>

int main()
{
    int N, number;
    std::cin >> N;

    std::multiset<double> tree;
    for (int i = 0; i < N; ++i)
    {
        std::cin >> number;
        tree.insert(number);
    }

    double resultSum = 0;
    while (tree.size() > 1)
    {
        auto first = tree.begin(), second = std::next(first);
        double sum = *first + *second;
        resultSum += sum * 0.05;
        tree.erase(first);
        tree.erase(second);
        tree.insert(sum);
    }

    std::cout << std::fixed;
    std::cout.precision(2);
    std::cout << resultSum;
}
