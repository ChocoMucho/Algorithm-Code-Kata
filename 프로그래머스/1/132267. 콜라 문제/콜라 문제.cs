using System;

public class Solution {
    public int solution(int a, int b, int n) { //총 n개이고 a개당 b개 받음
        int answer = 0;
        
        while(n >= a)
        {
            answer += (n / a) * b;
            n = (n / a) * b + n % a;
        }
        
        return answer;
    }
}