using System;
using System.Text;

public class Solution {
    public string solution(int[] numbers) {
        string[] stringArray = Array.ConvertAll(numbers, a => a.ToString());
        Array.Sort(stringArray, (a,b) => (b+a).CompareTo(a+b));
        
        StringBuilder sb = new StringBuilder();
        foreach(string numString in stringArray)
        {
            sb.Append(numString);
        }
        
        if(sb[0] == '0')
            return "0";
        
        return sb.ToString();
    }
}