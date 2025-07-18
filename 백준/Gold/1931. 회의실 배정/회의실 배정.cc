#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
	int n, result = 0;
	cin >> n;
	vector<pair<int, int>> vecPair(n);

	int s, e;
	for (int i = 0; i < n; ++i)
	{
		cin >> s >> e;
		vecPair[i].first = e;
		vecPair[i].second = s;
	}

	sort(vecPair.begin(), vecPair.end());
	// 1차 세팅 완료

	int current = 0;

	for (int i = 0; i < n; ++i)
	{
		if (vecPair[i].second >= current)
		{
			current = vecPair[i].first;
			++result;
		}
		else
			continue;
	}

	cout << result;
}