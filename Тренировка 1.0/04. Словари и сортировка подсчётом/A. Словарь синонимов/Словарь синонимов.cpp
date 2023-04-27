#include <iostream>
#include <unordered_map>

int main()
{
    int N;
    std::cin >> N;
    std::string synonym1;
    std::string synonym2;
    std::unordered_map<std::string, std::string> map;
    for (int i = 0; i < N; ++i)
    {
        std::cin >> synonym1;
        std::cin >> synonym2;
        if (!map.count(synonym1)) map.emplace(std::make_pair(synonym1, synonym2));
        if (!map.count(synonym2)) map.emplace(std::make_pair(synonym2, synonym1));
    }
    std::cin >> synonym1;
    std::cout << map[synonym1];
}
