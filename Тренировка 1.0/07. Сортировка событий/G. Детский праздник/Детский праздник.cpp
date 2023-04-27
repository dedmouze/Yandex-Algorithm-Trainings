#include <algorithm>
#include <iostream>
#include <vector>

int main()
{
	int M, N, T, Z, Y;
	std::cin >> M >> N;

	std::vector<std::vector<int>> events(N, std::vector<int>(6));
	for (int i = 0; i < N; ++i)
	{
		std::cin >> T >> Z >> Y;
		events[i] = { T, T, Z, Y, 0, i };
	}

	std::sort(events.begin(), events.end());

	int count = 0, total = 0;
	std::vector<int> answer(N, 0);
	while (count < M)
	{
		int min_time = events[0][0];
		total += min_time;
		for (auto& event : events)
		{
			event[0] -= min_time;
			if (event[0] == 0)
			{
				++event[4];
				++answer[event[5]];
				++count;
				if (count == M) break;

				if (event[2] == event[4])
				{
					event[0] = event[1] + event[3];
					event[4] = 0;
				}
				else event[0] = event[1];
			}

			if (event[0] < events[0][0]) std::swap(event, events[0]);
		}
	}

	std::cout << total << std::endl;
	for (int& i : answer) std::cout << i << " ";
}
