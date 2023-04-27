#include <iostream>
#include <vector>

bool check(int middle, int K, std::vector<int>& lines)
{
	int count = 0;
	for (int i = 0; i < lines.size(); ++i) count += lines[i] / middle;
	return count >= K;
};

int main()
{
	int N, K, number, max = -1;
	std::cin >> N >> K;

	std::vector<int> lines(N);
	for (int i = 0; i < N; ++i)
	{
		std::cin >> number;
		lines[i] = number;
		if (max < number) max = number;
	}

	int middle, left = 0, right = max;
	while (left < right)
	{
		middle = (left + right + 1) / 2;
		if (check(middle, K, lines)) left = middle;
		else right = middle - 1;
	}

	std::cout << left;
}
