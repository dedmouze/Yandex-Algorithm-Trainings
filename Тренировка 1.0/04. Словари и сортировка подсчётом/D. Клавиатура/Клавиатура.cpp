#include <iostream>
#include <map>

int main()
{
	int n, k;
	std::cin >> n;
	std::map<int, int> map;
	for (int i = 1; i <= n; ++i) std::cin >> map[i];

	std::cin >> k;
	for (int i = 1; i <= k; ++i)
	{
		int number;
		std::cin >> number;
		--map[number];
	}

	for (auto pair : map)
		std::cout << (pair.second < 0 ? "YES" : "NO") << std::endl;
}
