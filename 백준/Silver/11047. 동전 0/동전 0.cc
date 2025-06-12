#include <iostream>
using namespace std;

int main()
{
	int n, k;
	int result = 0;

	cin >> n >> k;

	int coins[10];

	for (int i = 0; i < n; ++i)
	{
		cin >> coins[i];
	}

	for (int i = n - 1; i >= 0; --i)
	{
		if (coins[i] <= k)
		{
			result += k / coins[i];
			k %= coins[i];
		}
	}

	cout << result;
}