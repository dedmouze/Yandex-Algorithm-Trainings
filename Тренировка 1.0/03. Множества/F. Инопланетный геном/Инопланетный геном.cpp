#include <iostream>
#include <string>
#include <unordered_set>

int main()
{
    std::string gen1, gen2;
    std::cin >> gen1 >> gen2;

    std::string pair;
    std::unordered_set<std::string> set;
    for (int i = 0; i < gen2.size() - 1; ++i)
    {
        pair = gen2[i];
        pair += gen2[i + 1];
        set.emplace(pair);
    }

    int count = 0;
    for (int i = 0; i < gen1.size() - 1; ++i)
    {
        pair = gen1[i];
        pair += gen1[i + 1];
        if (set.count(pair)) count++;
    }

    std::cout << count;
}
