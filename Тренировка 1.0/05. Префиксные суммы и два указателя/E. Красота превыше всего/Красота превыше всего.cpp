#include <unordered_map>
#include <iostream>
#include <climits>
#include <vector>

int main()
{
	int N, K;
	std::cin >> N >> K;

	std::vector<int> nums(N);
	for (int i = 0; i < N; ++i) std::cin >> nums[i];

	std::pair<int, int> min_answer;
	int left = 0, right = 1, min_window = INT_MAX;
	std::unordered_map<int, int> map{ { nums[left], 1 } };
	while (left < right && right < N)
	{
		map[nums[right]]++;

		while (map.size() == K)
		{
			map[nums[left]]--;
			if (map[nums[left]] == 0) map.erase(nums[left]);
			if (min_window > right - left + 1)
			{
				min_window = right - left + 1;
				min_answer = { left + 1, right + 1 };
			}
			++left;
		}

		++right;
	}

	std::cout << min_answer.first << " " << min_answer.second;
}
