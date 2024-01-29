using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        string str = "";
        
        int a = 0;
        
        
        while(n > 0) // 3진법 만들기
        {
            str = (n%3) + str ;
            n /= 3;
        }
        
        for(int i = 0; i < str.Length; ++i)
        {
            answer += (str[i]-48) * (int)Math.Pow(3,i);
        }
        
        
        return answer;
    }
}