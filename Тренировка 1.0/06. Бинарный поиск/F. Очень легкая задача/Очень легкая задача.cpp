#include <iostream>

int main()
{
	unsigned long N, x, y;
	std::cin >> N >> x >> y;

	--N;
	unsigned long min = std::min(x, y);
	unsigned long middle, left = 0, right = min * N;
	while (left < right)
	{
		middle = (left + right) / 2;
		if (middle / x + middle / y >= N) right = middle;
		else left = middle + 1;
	}

	std::cout << left + min;
}
