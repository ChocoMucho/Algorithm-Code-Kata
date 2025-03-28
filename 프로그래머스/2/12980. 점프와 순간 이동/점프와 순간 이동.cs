using System;

class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        while(0 < n)
        {
            if(n % 2 == 0) // n이 짝수일 때
                n = n / 2;
            else
            {
                n -= 1;
                ++answer;
            }
        }

        return answer;
    }
}