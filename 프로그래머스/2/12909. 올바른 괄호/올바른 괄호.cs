using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        Stack<char> stack = new Stack<char>();
        
        for(int i = 0; i < s.Length; ++i)
        {
            if(s[i] == '(')
                stack.Push('(');
            else
            {
                if(stack.Count > 0)
                    stack.Pop();
                else
                    return false;
            }
        }
        
        if(stack.Count != 0) return false;
        
        return answer;
    }
} 