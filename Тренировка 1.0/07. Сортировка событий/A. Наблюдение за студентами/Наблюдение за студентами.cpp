#include <algorithm>
#include <iostream>
#include <vector>

int main()
{
    int N, M, number;
    std::cin >> N >> M;

    std::vector<std::pair<int, int>> watchers;
    for (int i = 0; i < M; ++i)
    {
        std::cin >> number;
        watchers.push_back({ number, -1 });

        std::cin >> number;
        watchers.push_back({ number, 1 });
    }

    std::sort(watchers.begin(), watchers.end());

    int count = 0, controlled_students = 0, start;
    for (int i = 0; i < watchers.size(); ++i)
    {
        if (watchers[i].second == -1)
        {
            if (count == 0) start = i;
            ++count;
        }
        else --count;

        if (count == 0) controlled_students += watchers[i].first - watchers[start].first + 1;
    }

    std::cout << N - controlled_students;
}
