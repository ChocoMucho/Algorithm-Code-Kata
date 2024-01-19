using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length <= 1)
            return new int[]{-1};
        
        int[] answer;
                                
        int min = arr.Min();
        
        answer =arr.Where(num => num > min).ToArray();
        
        
        
        
        return answer;
    }
}