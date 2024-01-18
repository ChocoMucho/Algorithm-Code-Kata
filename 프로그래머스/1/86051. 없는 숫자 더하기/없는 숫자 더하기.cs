using System;

public class Solution {
    public int solution(int[] numbers) {
        int total = 9*5;
        
        for(int i=0; i<numbers.Length; ++i)
        {
            total -= numbers[i];
        }
        
        return total;
    }
}