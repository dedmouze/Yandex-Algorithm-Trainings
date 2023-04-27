#include <algorithm>
#include <iostream>
#include <vector>

int main()
{
	int N, M, a, b, point;
	std::cin >> N >> M;

	std::vector<std::pair<int, std::pair<int, int>>> vector;
	for (int i = 0; i < N; ++i)
	{
		std::cin >> a >> b;
		if (a < b)
		{
			vector.push_back({ a, { -1, i } });
			vector.push_back({ b, { 1, i } });
		}
		else
		{
			vector.push_back({ b, { -1, i } });
			vector.push_back({ a, { 1, i } });
		}
	}

	for (int i = 0; i < M; ++i)
	{
		std::cin >> point;
		vector.push_back({ point, { 0, i } });
	}

	std::sort(vector.begin(), vector.end());

	int count = 0;
	std::vector<int> answer(M);
	for (int i = 0; i < vector.size(); ++i)
	{
		if (vector[i].second.first == -1) ++count;
		else if (vector[i].second.first == 1) --count;
		else answer[vector[i].second.second] = count;
	}

	for (int i = 0; i < answer.size(); ++i) std::cout << answer[i] << " ";
}
