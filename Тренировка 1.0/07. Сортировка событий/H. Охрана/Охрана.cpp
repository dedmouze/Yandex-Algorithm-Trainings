#include <unordered_set>
#include <algorithm>
#include <iostream>
#include <vector>

int main()
{
	int K, N;
	std::cin >> K;
	
	for (int i = 0; i < K; ++i)
	{
		std::cin >> N;
		int start, end;
		std::vector<std::tuple<int, int, int>> events;
		for (int j = 0; j < N; ++j)
		{
			std::cin >> start >> end;
			events.push_back({ start, -1, j });
			events.push_back({ end, 1, j });
		}

		std::sort(events.begin(), events.end());

		bool flag = true;
		int prev_time = -1;
		std::unordered_set<int> now, good;
		for (auto& [time, state, index] : events)
		{
			if (time != 0 && now.empty())
			{
				flag = false;
				break;
			}
			if (now.size() == 1 && time != prev_time)
				for (int k : now) good.insert(k);
			if (state == -1) now.insert(index);
			else now.erase(index);
			prev_time = time;
		}
		if (std::get<0>(events.back()) != 10000) flag = false;
		if (flag && good.size() == N) std::cout << "Accepted\n";
		else std::cout << "Wrong Answer\n";
	}
}
