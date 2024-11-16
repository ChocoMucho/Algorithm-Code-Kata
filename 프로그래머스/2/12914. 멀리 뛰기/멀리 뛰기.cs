using System;
using System.Collections.Generic;

public class Solution {
    Dictionary<int, long> memo = new Dictionary<int, long>();
    
    public long solution(int n) {        
        return Fibo(n);
    }
    
    public long Fibo(int n)  //1,2
    {
        if(n <= 2)
            return n;
        
        if(memo.ContainsKey(n))
            return memo[n];
        
        memo[n] = (Fibo(n - 1)% 1234567 + Fibo(n - 2)% 1234567) % 1234567;
        
        return memo[n];
    }
}