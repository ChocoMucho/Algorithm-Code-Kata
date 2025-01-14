using System;

public class Solution {
    public long solution(long w, long h) {
        long answer = 0;
        long gcd = GCD(w,h);        
        
        answer = (long)(w*h)-(long)(w+h - gcd);
        
        return answer;
    }
    
    public long GCD(long m, long n)
    {
        if(n == 0)
            return m;
        return GCD(n, m%n);
    }
}