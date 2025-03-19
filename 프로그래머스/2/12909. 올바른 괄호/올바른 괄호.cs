using System;

public class Solution {
    public bool solution(string s) {
        bool answer = false;
        int check = 0;
        
        if(s[0] == ')') return false;
        if(s[s.Length - 1] == '(') return false;
           
        for(int i = 0; i < s.Length; ++i)
        {
            if(s[i] == '(')
                ++check;
            else
                --check;
            
            if(check < 0)
                break;
        }
        
        if(check == 0) answer = true;
        
        return answer;
    }
}