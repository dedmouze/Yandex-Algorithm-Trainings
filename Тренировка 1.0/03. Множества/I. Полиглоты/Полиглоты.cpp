#include <iostream>
#include <unordered_set>
#include <unordered_map>

int main()
{
    int N, M;
    std::cin >> N;
    std::string language;
    std::unordered_set<std::string> allLanguages;
    std::unordered_map<std::string, int> languagesMap;
    for (int i = 0; i < N; i++)
    {
        std::cin >> M;
        for (int j = 0; j < M; j++)
        {
            std::cin >> language;
            if (!languagesMap.count(language)) languagesMap.emplace(std::make_pair(language, 0));
            languagesMap[language]++;
            allLanguages.emplace(language);
        }
    }

    int onlyCount = 0;
    for(auto pair : languagesMap)
        if (pair.second == N) onlyCount++;

    std::cout << onlyCount << std::endl;
    for (auto pair : languagesMap)
        if (pair.second == N) std::cout << pair.first << std::endl;

    std::cout << allLanguages.size() << std::endl;
    for (auto language : allLanguages) std::cout << language << std::endl;
}