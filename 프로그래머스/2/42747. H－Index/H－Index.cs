using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        
        Array.Sort(citations);
        Array.Reverse(citations);
       
        for(int i = 0; i < citations.Length; ++i)
        {
            if(citations[i] >= i+1)
                ++answer;
        }
        
        return answer;
    }
}