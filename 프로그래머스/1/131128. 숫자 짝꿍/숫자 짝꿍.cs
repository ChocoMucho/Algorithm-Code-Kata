using System;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        
        int[] xArr = new int[10];
        int[] yArr = new int[10];
        
        for(int i = 0; i < X.Length; ++i)
        {
            ++xArr[int.Parse(X[i].ToString())];
        }
        
        for(int i = 0; i < Y.Length; ++i)
        {
            ++yArr[int.Parse(Y[i].ToString())];
        }
        
        for(int i = 9; i >= 0; --i)
        {
            if(xArr[i] <= 0 || yArr[i] <= 0)
                continue;
            
            
            int min = xArr[i] <= yArr[i] ? xArr[i] : yArr[i];
            
            answer += string.Concat(Enumerable.Repeat(i, min));
           
        }
        
        if (answer.Length == 0)
            return "-1";
        else if(answer[0] == '0')
            return "0";
        
        return answer;
    }
}