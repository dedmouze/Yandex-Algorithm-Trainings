#include <algorithm>
#include <iostream>
#include <vector>

int main()
{
	int N, D, x;
	std::cin >> N >> D;

	std::vector < std::pair<int, std::pair<int, int>>> students;
	for (int i = 0; i < N; ++i)
	{
		std::cin >> x;
		students.push_back({ x, { -1, i } });
		students.push_back({ x + D, { 1, i } });
	}

	std::sort(students.begin(), students.end());

	int count = 0, max_count = 0;
	for (int i = 0; i < students.size(); ++i)
	{
		if (students[i].second.first == -1)
		{
			++count;
			if (count > max_count) max_count = count;
		}
		else --count;
	}

	x = 0;
	std::vector<int> variants(N);
	for (auto pair : students)
	{
		if (pair.second.first == -1)
		{
			variants[pair.second.second] = x % max_count + 1;
			x++;
		}
	}

	std::cout << max_count << std::endl;
	for (int i = 0; i < variants.size(); ++i) std::cout << variants[i] << " ";
}
