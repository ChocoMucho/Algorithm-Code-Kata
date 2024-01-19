using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;
        if(arr.Length > 1)
            answer = new int[arr.Length-1];
        else
            return new int[]{-1};
        
        int min = arr.Min();
        
        answer =arr.Where(num => num > min).ToArray();
        
        return answer;
    }
}