using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> temp = new List<int>();
        
        for(int i = 0; i < score.Length; ++i)
        {
            if(temp.Count >= k)
            {
                if(temp[0] >= score[i])
                {
                    answer[i] = temp[0];
                    continue;
                }
                
                temp.RemoveAt(0);
            }
            temp.Add(score[i]);
            temp.Sort();
            answer[i] = temp[0];
        }
        
        
        return answer;
    }
}