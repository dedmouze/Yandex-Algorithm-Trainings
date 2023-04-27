#include <unordered_set>
#include <algorithm>
#include <iostream>
#include <vector>
#include <tuple>

typedef std::tuple<int, int, int> date;

int main()
{
    int N;
    std::cin >> N;

    date birth, death;
    auto& [b_year, b_month, b_day] = birth;
    auto& [d_year, d_month, d_day] = death;
    std::vector<std::tuple<date, int, int>> events;
    for (int i = 0; i < N; ++i)
    {
        std::cin >> b_day >> b_month >> b_year >> d_day >> d_month >> d_year;
        b_year += 18;
        if (birth < death)
        {
            events.push_back({ birth, 1, i + 1 });
            b_year = b_year - 18 + 80;
            events.push_back({ std::min(birth, death), -1, i + 1});
        }
    }

    std::sort(events.begin(), events.end());

    if (events.size() == 0) std::cout << 0;
    else
    {
        bool found = false;
        std::unordered_set<int> set;    
        for (const auto& [date, flag, index] : events)
        {
            if (flag == 1)
            {
                set.insert(index);
                found = true;
            }
            else
            {
                if (found)
                {
                    for (const int& k : set) std::cout << k << " ";
                    std::cout << std::endl;
                    found = false;
                }
                
                set.erase(index);
            }
        }
    }
}

