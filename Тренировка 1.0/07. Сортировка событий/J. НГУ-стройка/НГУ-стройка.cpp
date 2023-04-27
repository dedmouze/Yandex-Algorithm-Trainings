#include <algorithm>
#include <iostream>
#include <vector>
#include <tuple>
#include <set>

int main()
{
	int N, W, L, x1, y1, z1, x2, y2, z2, area;
	std::cin >> N >> W >> L;

	std::vector<std::tuple<int, int, int, int>> events;
	for (int i = 0; i < N; ++i)
	{
		std::cin >> x1 >> y1 >> z1 >> x2 >> y2 >> z2;
		area = std::abs(x2 - x1) * std::abs(y2 - y1);
		events.push_back({ z1, 1, area, i + 1 });
		events.push_back({ z2, -1, area, i+ 1 });
	}

	std::sort(events.begin(), events.end());

	int min = N + 1, cur_area = 0, count = 0;
	for (auto& [time, state, area, index] : events)
	{
		if (state == 1)
		{
			++count;
			cur_area += area;
			if (cur_area == W * L && min > count) min = count;
		}
		else
		{
			--count;
			cur_area -= area;
		}
	}

	if (min == N + 1) std::cout << "NO";
	else
	{
		cur_area = 0, count = 0;
		std::set<int> set;
		for (auto& [time, state, area, index] : events)
		{
			if (state == 1)
			{
				++count;
				cur_area += area;
				set.insert(index);
				if (cur_area == W * L && count == min) break;
			}
			else
			{
				--count;
				cur_area -= area;
				set.erase(index);
			}
		}

		std::cout << "YES\n" << min << std::endl;
		for (auto& i : set) std::cout << i << std::endl;
	}
}
