#include <iostream>
#include <queue>
#include <set>

int main()
{
    int N, K, number;
    std::cin >> N >> K;
    std::multiset<int> set;
    std::queue<int> queue;
    for (int i = 0; i < N; ++i)
    {
        std::cin >> number;
        set.insert(number);
        queue.push(number);

        if (i >= K - 1)
        {
            std::cout << *(set.begin()) << std::endl;
            auto windowStart = set.find(queue.front());
            set.erase(windowStart);
            queue.pop();
        }
    }
}