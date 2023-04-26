#include <iostream>
#include <vector>
#include <set>

int main()
{
	unsigned long M;
	unsigned int N;
	std::cin >> M >> N;
	unsigned long a, b;

	std::set<std::pair<unsigned long, unsigned long>> set;
	for (int i = 0; i < N; ++i)
	{
		std::cin >> a >> b;
		std::vector<std::pair<unsigned long, unsigned long>> vector;
		for (auto pair : set)
			if (a >= pair.first && a <= pair.second || b >= pair.first && b <= pair.second || a < pair.first && b > pair.second)
				vector.push_back(pair);
			
		for (int j = 0; j < vector.size(); ++j) set.erase(vector[j]);
		set.insert(std::make_pair(a, b));
	}

	std::cout << set.size() << std::endl;
}