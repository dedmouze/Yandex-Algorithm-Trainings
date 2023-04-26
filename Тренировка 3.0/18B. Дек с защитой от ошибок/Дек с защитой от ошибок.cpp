#include <iostream>
#include <deque>

int main()
{
	std::deque<int> deque;
	std::string input;
	std::cin >> input;
	while (input != "exit")
	{
		int number;
		if (input == "push_back")
		{
			std::cin >> number;
			deque.push_back(number);
			std::cout << "ok\n";
		}
		else if (input == "push_front")
		{
			std::cin >> number;
			deque.push_front(number);
			std::cout << "ok\n";
		}
		else if (input == "pop_back")
		{
			if (deque.size() > 0)
			{
				std::cout << deque.back() << std::endl;
				deque.pop_back();
			}
			else std::cout << "error\n";
		}
		else if (input == "pop_front")
		{
			if (deque.size() > 0)
			{
				std::cout << deque.front() << std::endl;
				deque.pop_front();
			}
			else std::cout << "error\n";
		}
		else if (input == "back")
		{
			if (deque.size() > 0) std::cout << deque.back() << std::endl;
			else std::cout << "error\n";
		}
		else if (input == "front")
		{
			if (deque.size() > 0) std::cout << deque.front() << std::endl;
			else std::cout << "error\n";
		}
		else if (input == "clear")
		{
			deque.clear();
			std::cout << "ok\n";
		}
		else if (input == "size") std::cout << deque.size() << std::endl;

		std::cin >> input;
	}

	std::cout << "bye";
}
