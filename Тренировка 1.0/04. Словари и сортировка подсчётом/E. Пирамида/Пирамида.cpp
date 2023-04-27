#include <iostream>
#include <unordered_map>

int main()
{
	int N, width, height;
	std::cin >> N;
	std::unordered_map<int, int> map;
	long maxHeight = 0;
	for (int i = 0; i < N; ++i)
	{
		std::cin >> width >> height;
		if (!map.count(width))
		{
			map[width] = height;
			maxHeight += height;
		}
		else if (height > map[width])
		{
			maxHeight -= map[width];
			maxHeight += height;
			map[width] = height;
		}
	}
	
	std::cout << maxHeight;
}
