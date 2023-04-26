#include <iostream>

int main()
{
	short pos;
	long long N, K, row;
	std::cin >> N >> K >> row >> pos;

	long long number = (row - 1) * 2 + pos;
	if (number + K > N && number - K < 1)
	{
		std::cout << -1;
		return 0;
	}

	long long r1 = 1000000000, r2 = -1000000000, c1 = 0, c2 = 0;
	if (number + K <= N)
	{
		r1 = (number + K - 1) / 2 + 1;
		c1 = (number + K - 1) % 2 + 1;
	}
	if (number - K > 0)
	{
		r2 = (number - K - 1) / 2 + 1;
		c2 = (number - K - 1) % 2 + 1;
	}

	if (r1 - row <= row - r2) std::cout << r1 << " " << c1;
	else std::cout << r2 << " " << c2;
}