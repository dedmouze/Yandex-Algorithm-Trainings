#include <iostream>
#include <deque>

int main()
{
	int N, number;
	std::cin >> N;
	char operation;
	std::deque<int> mainQueue;
	std::deque<int> supQueue;
	for (int i = 0; i < N; ++i)
	{
		std::cin >> operation;
		if (operation == '-')
		{
			std::cout << mainQueue.front() << std::endl;
			mainQueue.pop_front();
		}
		else
		{
			std::cin >> number;
			if (operation == '+') supQueue.push_back(number);
			else if (operation == '*') supQueue.push_front(number);
		}

		if (mainQueue.size() < supQueue.size())
		{	
			mainQueue.push_back(supQueue.front());
			supQueue.pop_front();
		}
	}

	
}