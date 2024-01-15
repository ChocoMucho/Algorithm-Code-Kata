using System;


public class Solution {
    public long solution(long n) {
        long temp = (long)Math.Sqrt(n);
        
        return (temp*temp != n)? -1 : (temp+1)*(temp+1);
    }
}