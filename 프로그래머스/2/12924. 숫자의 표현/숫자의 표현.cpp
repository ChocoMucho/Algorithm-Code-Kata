#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(int n) {
    int answer = 0;
    
    for(int i = 1; i <= n / 2; ++i)
    {
        int temp = 0;
        for(int j = i; j < n; ++j)
        {
            temp += j;
            if(temp > n) break;
            if(temp == n)
            {
                ++answer;
                break;
            }
        }
    }
    ++answer;
    
    return answer;
}