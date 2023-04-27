#include <unordered_set>
#include <algorithm>
#include <iostream>
#include <vector>
#include <tuple>

int main()
{
    int N, a, b;
    std::cin >> N;

    std::vector<std::tuple<int, int, int>> customers;
    for (int i = 0; i < N; ++i)
    {
        std::cin >> a >> b;
        if (b - a >= 5)
        {
            customers.push_back(std::make_tuple(a, -1, i));
            customers.push_back(std::make_tuple(b - 5, 1, i));
        }
    }

    std::sort(customers.begin(), customers.end());

    if (customers.size() == 0) std::cout << "0 10 20";
    else if (customers.size() == 2) std::cout << "1 " << std::get<0>(customers[0]) << " " << std::get<0>(customers[0]) + 10;
    else
    {
        std::unordered_set<int> set;
        int best_answer = 0, first_best = 0, second_best = 0;
        for (int i = 0; i < customers.size(); ++i)
        {
            auto [time_1, flag_1, index_1] = customers[i];
            if (flag_1 == -1)
            {
                set.insert(index_1);
                if (set.size() > best_answer)
                {
                    best_answer = set.size();
                    first_best = time_1;
                    second_best = time_1 + 5;
                }
            }

            int second_count = 0;
            for (int j = i + 1; j < customers.size(); ++j)
            {
                auto [time_2, flag_2, index_2] = customers[j];
                if (flag_2 == -1 && !set.count(index_2)) ++second_count;
                if (time_2 - 5 >= time_1 && set.size() + second_count > best_answer)
                {
                    best_answer = set.size() + second_count;
                    first_best = time_1;
                    second_best = time_2;
                }
                if (flag_2 == 1 && !set.count(index_2)) --second_count;
            }

            if (flag_1 == 1) set.erase(index_1);
        }

        std::cout << best_answer << " " << first_best << " " << second_best;
    }
}
