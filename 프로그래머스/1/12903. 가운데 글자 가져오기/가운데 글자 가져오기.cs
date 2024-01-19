public class Solution {
    public string solution(string s) {
        string answer = "";
        
        int start = -1;
        int length = -1;
        
        if(s.Length % 2 == 0)//짝수면~
        {
            start = (s.Length/2)-1;
            length = 2;
        }
        else
        {
            start = s.Length/2;
            length = 1;
        }
        
        answer = s.Substring(start, length);
        
        return answer;
    }
}