using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int sameIndex = 0;
        int diffIndex = 0;
        char word = ' ';      
        bool isStart = true;

        for(int i = 0; i < s.Length; ++i)
        {
            if(isStart)
            {
                word = s[i];
                ++sameIndex;
                isStart = false;                 
            }
            else
            {
                if(s[i] == word)
                {
                    ++sameIndex;
                }
                else
                {
                    ++diffIndex;
                }
            }
            
            if(sameIndex == diffIndex)
            {
                ++answer;
                sameIndex = 0;
                diffIndex = 0;
                isStart = true;
            }
            
            if(i == s.Length - 1 && !isStart)
                ++answer;
        }
        
        return answer;
    }
}