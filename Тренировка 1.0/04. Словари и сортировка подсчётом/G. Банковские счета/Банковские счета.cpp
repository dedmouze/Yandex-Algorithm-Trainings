#include <iostream>
#include <unordered_map>

int main()
{
	int money;
	unsigned percentage;
	std::string command, nameFrom, nameTo;
	std::unordered_map<std::string, int> map;
	while (std::cin >> command)
	{
		if (command == "DEPOSIT")
		{
			std::cin >> nameFrom >> money;
			map[nameFrom] += money;
		}
		else if (command == "WITHDRAW")
		{
			std::cin >> nameFrom >> money;
			map[nameFrom] -= money;
		}
		else if (command == "TRANSFER")
		{
			std::cin >> nameFrom >> nameTo >> money;
			map[nameFrom] -= money;
			map[nameTo] += money;
		}
		else if (command == "INCOME")
		{
			std::cin >> percentage;
			for (auto& [name, money] : map)
			{
				if (money < 0) continue;
				money += money * percentage / 100;
			}
		}
		else
		{
			std::cin >> nameFrom;
			if (map.count(nameFrom)) std::cout << map[nameFrom] << std::endl;
			else std::cout << "ERROR\n";
		}
	}
}
