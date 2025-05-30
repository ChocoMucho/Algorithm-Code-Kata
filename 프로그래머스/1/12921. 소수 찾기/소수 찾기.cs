using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        if(n == 2) return 1;
        
        answer = 1;
        for(int i = 3; i <= n; i+=2)
        {
            
            if(IsPrime(i)) ++answer;
        }
        
        return answer;
    }
    
    public bool IsPrime(int n)
    {
        for(int i = 2; i * i <= n; ++i)
        {
            if(i * i == n) return false;
            else if(n % i == 0) return false;
        }
        
        return true;
    }
}