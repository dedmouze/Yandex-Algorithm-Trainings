#include <unordered_set>
#include <iostream>
#include <climits>
#include <vector>
#include <queue>
#include <list>

int main()
{
	int N, K, P, number;
	std::cin >> N >> K >> P;

	int* sequence = new int[P];
	std::vector<std::list<int>> vector(N);
	for (int i = 0; i < P; ++i)
	{
		std::cin >> sequence[i];
		vector[--sequence[i]].push_back(i);
	}

	int min = 0;
	std::unordered_set<int> cars;
	std::priority_queue<std::pair<int, int>> p_queue;
	for (int i = 0; i < P; ++i)
	{
		int cur = sequence[i];
		vector[cur].erase(vector[cur].begin());

		if (cars.find(cur) == cars.end())
		{
			if (cars.size() >= K)
			{
				cars.erase(p_queue.top().second);
				p_queue.pop();
			}
			cars.insert(cur);
			min++;
		}
		
		if (vector[cur].empty()) p_queue.push(std::make_pair(INT_MAX, cur));
		else p_queue.push(std::make_pair(vector[cur].front(), cur));
	}

	std::cout << min;

	delete[] sequence;
}
