using System;
using System.Diagnostics;

public class Solution {
    public long solution(int a, int b) {
        
        if(a == b) return a;
        
        return ((long)(Math.Abs(a - b)+1) * (b + a)) / 2;
    }
}