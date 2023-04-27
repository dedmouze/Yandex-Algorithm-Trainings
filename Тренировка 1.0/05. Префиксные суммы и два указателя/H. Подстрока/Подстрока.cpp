#include <unordered_map>
#include <iostream>
#include <vector>

int main()
{
	int N, K;
	std::string line;
	std::cin >> N >> K >> line;

	std::pair<int, int> max = {0, -1};
	int left = 0, right = 0;
	std::unordered_map<char, int> map;
	for (int left = 0, right = 0; right < N; ++right)
	{
		++map[line[right]];
		while (map[line[right]] > K)
		{
			--map[line[left]];
			++left;
		}

		if (right - left + 1 > max.first)
		{
			max.first = right - left + 1;
			max.second = left + 1;
		}
	}

	std::cout << max.first << " " << max.second;
}
