#include <algorithm>
#include <iostream>
#include <vector>

int main()
{
	int N;
	std::cin >> N;

	std::vector<int> required_powers(N);
	for (int i = 0; i < N; ++i) std::cin >> required_powers[i];

	int M;
	std::cin >> M;

	int power, cost;
	std::vector<std::pair<int, int>> conditioners(M);
	for (int i = 0; i < M; ++i)
	{
		std::cin >> power >> cost;
		conditioners[i] = { cost, power };
	}

	std::sort(required_powers.begin(), required_powers.end());
	std::sort(conditioners.begin(), conditioners.end());
		
	int top = 0, bottom = 0, sum = 0;
	while (top < N)
	{
		std::pair<int, int> conditioner = conditioners[bottom];
		if (conditioner.second >= required_powers[top])
		{
			sum += conditioner.first;
			++top;
		}
		else ++bottom;
	}

	std::cout << sum;
}
