using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        
        int num = p.Length;
        
        for(int i = 0; i <= t.Length - num; ++i)
        {
            //int numOfT = 
            if(long.Parse(p) >= long.Parse(t.Substring(i, num)))
                ++answer;
        }
        
        return answer;
    }
}