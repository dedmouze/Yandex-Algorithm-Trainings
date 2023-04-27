#include <algorithm>
#include <iostream>
#include <vector>
#include <tuple>

int main()
{
    int N, hours_start, minutes_start, hours_end, minutes_end, overnight = 0;
    std::cin >> N;

    std::vector<std::tuple<int, int>> events;
    for (int i = 0; i < N; ++i)
    {
        std::cin >> hours_start >> minutes_start >> hours_end >> minutes_end;
        events.push_back({ hours_start * 60 + minutes_start, 1 });
        events.push_back({ hours_end * 60 + minutes_end, -1 });

        if (hours_start * 60 + minutes_start >= hours_end * 60 + minutes_end) ++overnight;
    }

    std::sort(events.begin(), events.end());

    int answer = 0, start = 0;
    for (int i = 0; i < events.size(); ++i)
    {
        auto [time, flag] = events[i];
        overnight += flag;
        if (overnight == N) start = time;
        if (flag == -1 && overnight == N - 1) answer += time - start;
    }

    if (overnight == N) answer += 24 * 60 - start;
    std::cout << answer;
}
