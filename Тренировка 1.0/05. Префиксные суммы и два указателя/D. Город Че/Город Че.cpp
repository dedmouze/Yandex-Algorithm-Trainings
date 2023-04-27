#include <iostream>
#include <vector>

int main()
{
	int N, R;
	std::cin >> N >> R;
	
	std::vector<int> nums(N);
	for (int i = 0; i < N; ++i) std::cin >> nums[i];

	long count = 0;
	int left = 0, right = 1;
	while (right < N)
	{
		int distance = nums[right] - nums[left];
		if (distance <= R) ++right;
		else
		{
			count += N - right;
			++left;
		}
	}

	std::cout << count << std::endl;
}
