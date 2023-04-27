#include <iostream>
#include <vector>

int RSQ(std::vector<int>& climb, std::vector<int>& descent, int left, int right)
{
	if (left < right) return climb[right] - climb[left];
	else return descent[left] - descent[right];
}

int main()
{
	int N;
	std::cin >> N;

	std::vector<int> nums(N);
	for (int i = 0; i < N; ++i) std::cin >> nums[i] >> nums[i];

	std::vector<int> climb(N), descent(N);
	climb[0] = 0, descent[0] = 0;
	for (int i = 1; i < N; ++i)
	{
		if (nums[i] > nums[i - 1])
		{
			climb[i] = climb[i - 1] + nums[i] - nums[i - 1];
			descent[i] = descent[i - 1];
		}
		else if (nums[i] < nums[i - 1])
		{
			climb[i] = climb[i - 1];
			descent[i] = descent[i - 1] + nums[i - 1] - nums[i];
		}
		else
		{
			climb[i] = climb[i - 1];
			descent[i] = descent[i - 1];
		}
	}

	int M, start, end;
	std::cin >> M;
	for (int i = 0; i < M; ++i)
	{
		std::cin >> start >> end;
		std::cout << RSQ(climb, descent, start - 1, end - 1) << std::endl;
	}
}
