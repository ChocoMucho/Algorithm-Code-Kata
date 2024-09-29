using System;

public class Solution {
    public long solution(int k, int d) {
        long answer = 0;
        long dxd = (long)d*d;
        
        for(long i = 0; i <= d; i += k)
        {
            long ixi = (long)i*i;
            long range = (long)Math.Sqrt(dxd - ixi);
            answer += 1 + (range/k);
        }
        
        return answer;
    }
}