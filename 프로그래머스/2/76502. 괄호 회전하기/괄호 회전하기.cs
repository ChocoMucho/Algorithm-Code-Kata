using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        for(int i = 0; i < s.Length; ++i)
        {
            string checkSubject = s.Substring(i) + s.Substring(0,i);
            
            if(CheckBracket(checkSubject))
                ++answer;                
        }
        
        
        return answer;
    }
    
    public bool CheckBracket(string checkSubject)
    {
        Stack<char> stack = new Stack<char>();
        string temp = "";
        
        for(int i=0; i < checkSubject.Length; ++i)
        {
            if(stack.Count > 0)
            {
                temp = stack.Peek().ToString() + checkSubject[i];
                if(temp == "()" || temp == "[]" || temp == "{}")
                {
                    stack.Pop();
                    continue;
                }
            }
            stack.Push(checkSubject[i]);
        }
        
        if(stack.Count > 0)
            return false;
        return true;
    }
}