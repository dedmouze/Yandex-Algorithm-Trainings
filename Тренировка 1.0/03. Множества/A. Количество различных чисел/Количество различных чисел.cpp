#include <iostream>
#include <unordered_set>

int main()
{
    std::unordered_set<int> set;
    int number;
    do
    {
        std::cin >> number;
        set.insert(number);
    } while (std::cin.get() != '\n');

    std::cout << set.size();
}
