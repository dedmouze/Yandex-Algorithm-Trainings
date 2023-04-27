#include <iostream>
#include <unordered_set>

int main()
{
    int N;
    std::cin >> N;

    std::unordered_set<int> set;
    for (int i = 0; i < N; i++)
    {
        int x, y;
        std::cin >> x >> y;
        set.emplace(x);
    }
    std::cout << set.size();
}