#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
	int n = 0;
	int result = 0;
	int temp = 0;

	cin >> n;
	
	vector<int> p(n);

	for (int i = 0; i < n; ++i)
	{
		cin >> p[i];
	}

	sort(p.begin(), p.end());
	
	for (int i = 0; i < n; ++i)
	{
		result += temp + p[i];
		temp += p[i];
	}

	cout << result;
}