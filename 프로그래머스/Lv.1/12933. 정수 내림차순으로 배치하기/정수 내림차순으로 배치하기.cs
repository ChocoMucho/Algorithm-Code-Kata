using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        string str = n.ToString();
        char[] charArr = str.ToCharArray();
        Array.Sort(charArr);
        Array.Reverse(charArr);
        
        answer = long.Parse(new string(charArr));
        
        return answer;
    }
}