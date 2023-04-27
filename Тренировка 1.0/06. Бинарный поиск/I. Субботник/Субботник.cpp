#include <algorithm>
#include <iostream>
#include <climits>
#include <vector>

bool check(int middle, int R, int C, std::vector<int> heights)
{
	int count = 0;
	for (int i = 0; i < heights.size() - C + 1;)
	{
		if (middle >= heights[i + C - 1] - heights[i])
		{
			++count;
			i += C;
		}
		else ++i;
	}

	return count >= R;
};

int main()
{
	int R, C, N, min = INT_MAX, max = -1, number;
	std::cin >> N >> R >> C;

	std::vector<int> heights(N);
	for (int i = 0; i < N; ++i)
	{
		std::cin >> number;
		heights[i] = number;
		if (min > number) min = number;
		if (max < number) max = number;
	}

	std::sort(heights.begin(), heights.end());

	int middle, left = 0, right = max - min;
	while (left < right)
	{
		middle = (left + right) / 2;
		if (check(middle, R, C, heights)) right = middle;
		else left = middle + 1;
	}

	std::cout << left;
}
