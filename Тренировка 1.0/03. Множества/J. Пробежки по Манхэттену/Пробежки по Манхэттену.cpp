#include <iostream>
#include <vector>
#include <tuple>

typedef std::tuple<int, int, int, int> rect;

void extend(rect& rect, const int t)
{
    auto& [min_plus, max_plus, min_minus, max_minus] = rect;
    min_plus -= t;
    max_plus += t;
    min_minus -= t;
    max_minus += t;
}

void intersect(rect& pos_rect, const rect& nav_rect)
{
    std::get<0>(pos_rect) = std::max(std::get<0>(pos_rect), std::get<0>(nav_rect));
    std::get<1>(pos_rect) = std::min(std::get<1>(pos_rect), std::get<1>(nav_rect));
    std::get<2>(pos_rect) = std::max(std::get<2>(pos_rect), std::get<2>(nav_rect));
    std::get<3>(pos_rect) = std::min(std::get<3>(pos_rect), std::get<3>(nav_rect));
}

int main()
{
    int t, d, n, xi, yi;
    std::cin >> t >> d >> n;
    rect pos_rect = { 0, 0, 0 , 0 }, nav_rect;
    for (int i = 0; i < n; ++i)
    {
        extend(pos_rect, t);
        std::cin >> xi >> yi;
        nav_rect = { xi + yi, xi + yi, xi - yi, xi - yi };
        extend(nav_rect, d);
        intersect(pos_rect, nav_rect);
    }

    std::vector<std::pair<int, int>> points;
    for (int x_plus_y = std::get<0>(pos_rect); x_plus_y <= std::get<1>(pos_rect); ++x_plus_y)
    {
        for (int x_minus_y = std::get<2>(pos_rect); x_minus_y <= std::get<3>(pos_rect); ++x_minus_y)
        {
            if ((x_plus_y + x_minus_y) % 2 == 0)
            {
                int x = (x_plus_y + x_minus_y) / 2;
                int y = x_plus_y - x;
                points.push_back({ x, y });
            }
        }
    }

    std::cout << points.size() << std::endl;
    for (int i = 0; i < points.size(); ++i) std::cout << points[i].first << " " << points[i].second << std::endl;
}
