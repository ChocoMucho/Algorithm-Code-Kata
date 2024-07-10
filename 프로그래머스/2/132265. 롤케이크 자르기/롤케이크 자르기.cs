using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;
        int key = 0;
        Dictionary<int, int> left = new Dictionary<int, int>();
        Dictionary<int, int> right = new Dictionary<int, int>();
        
        // 오른쪽에 몰아놓기
        for(int i = 0; i < topping.Length; ++i)
        {
            key = topping[i];
            if(!right.ContainsKey(key))
                right.Add(key, 0);
            
            ++right[key];
        }
        
        for(int i = 0; i < topping.Length; ++i) 
        {
            key = topping[i];
            if(!left.ContainsKey(key))
                left.Add(key, 0);
            
            ++left[key];
            --right[key];
            
            if(right[key] <= 0)
                right.Remove(key);                               
            
            if(left.Count == right.Count)
                ++answer;
        }
        
        return answer;
    }
}