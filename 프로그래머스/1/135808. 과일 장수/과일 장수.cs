using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        
        List<int> box = new List<int>();
        
        Array.Sort(score);
        Array.Reverse(score);
        
        for(int i = 0; i < score.Length; ++i)
        {
            box.Add(score[i]);
            if(i % m == (m - 1))
            {
                answer += box.Min() * m;
                box.Clear();
            }
        }
        
        return answer;
    }
}