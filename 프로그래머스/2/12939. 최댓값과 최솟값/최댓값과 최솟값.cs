using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] choppedString = s.Split(' ');
        
        List<int> nums = new List<int>();
        for(int i = 0; i < choppedString.Length; ++i)
        {
            nums.Add(int.Parse(choppedString[i]));
        }
        
        answer += nums.Min().ToString();
        answer += " ";
        answer += nums.Max().ToString();
        
        return answer;
    }
}