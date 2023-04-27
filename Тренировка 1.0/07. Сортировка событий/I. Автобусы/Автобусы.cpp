#include <algorithm>
#include <iostream>
#include <string>
#include <vector>
#include <tuple>

int main()
{
	int N, M, F, G, overnight = 0, s_time, e_time;
	std::string X, Y;
	std::cin >> N >> M;
	std::vector<std::tuple<int, int, int>> events;
	std::vector<int> count_buses(N + 1, 0), bus_balance(N + 1, 0);
	for (int i = 0; i < M; ++i)
	{
		std::cin >> F >> X >> G >> Y;
		s_time = std::stoi(X.substr(0, 2)) * 60 + std::stoi(X.substr(3, 2));
		e_time = std::stoi(Y.substr(0, 2)) * 60 + std::stoi(Y.substr(3, 2));
		if (s_time > e_time) ++overnight;
		--bus_balance[F];
		++bus_balance[G];
		events.push_back({ s_time, 1, F });
		events.push_back({ e_time, -1, G });
	}

	bool disbalance = false;
	for (int i = 0; i < N + 1; ++i)
		if (bus_balance[i] != 0) disbalance = true;

	if (disbalance) std::cout << -1;
	else
	{
		std::sort(events.begin(), events.end());
		for (auto& [time, state, city] : events)
		{
			if (state == -1) ++count_buses[city];
			else if (count_buses[city] > 0) --count_buses[city];
		}

		int answer = 0;
		for (int i = 0; i < N + 1; ++i) answer += count_buses[i];

		std::cout << answer + overnight;
	}
}
