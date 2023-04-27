#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;

int main()
{
	double a, b, c, d, e, f, x, y;
	std::cin >> a >> b >> c >> d >> e >> f;
	cout << setprecision(6) << fixed;

	const double zero = 10e-7;

	double D = a * d - c * b, Dx = e * d - f * b, Dy = a * f - c * e;
	if (D == 0)
	{
		if (fabs(a) + fabs(b) + fabs(c) + fabs(d) <= zero)
		{
			if (fabs(e) + fabs(f) <= zero) cout << 5;
			else cout << 0;
		}
		else if ((not fabs(Dx) <= zero) || (not fabs(Dy) <= zero)) cout << 0;
		else if (b == 0) 
		{
			if (not fabs(a) <= zero) cout << 3 << " " << e / a;
			else if (fabs(d) <= zero) cout << 3 << " " << f / c;
			else if (fabs(c) <= zero) cout << 4 << " " << f / d;
			else cout << 1 << " " << -c / d << " " << f / d;
		}
		else if (a == 0) 
		{
			if (not fabs(b) <= zero) cout << 4 << " " << e / b;
			else if (fabs(d) <= zero) cout << 3 << " " << f / c;
			else if (fabs(c) <= zero) cout << 4 << " " << f / d;
			else cout << 1 << " " << -c / d << " " << f / d;
		}
		else cout << 1 << " " << -a / b << " " << e / b;
	}
	else
	{
		x = Dx / D;
		y = Dy / D;
		cout << 2 << " " << x << " " << y;
	}
}
