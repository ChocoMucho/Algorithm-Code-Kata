using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        
        char temp;
        
        for(int i = 0; i < s.Length; ++i)
        {
            temp = s[i];            
            for(int j = 0; j < index; )
            {
                // 문자 증가
                temp = (char)((int)temp + 1);
                if(temp > 'z')
                    temp = 'a';
                // skip에서 temp를 담고있는가
                if(skip.Contains(temp))
                    continue;
                
                ++j;
            }
            
            // 다 잘 되고나서
            answer += temp;
        }
        
        
        return answer;
    }
}