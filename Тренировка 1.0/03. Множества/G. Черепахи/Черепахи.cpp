#include <iostream>
#include <unordered_set>


int main()
{
    int N;
    std::cin >> N;

    std::unordered_set<int> set;
    for (int i = 0; i < N; i++)
    {
        int ai, bi;
        std::cin >> ai >> bi;
        if (ai >= 0 && bi >= 0 && ai + bi == N - 1) set.emplace(bi);
    }

    std::cout << set.size();
}
