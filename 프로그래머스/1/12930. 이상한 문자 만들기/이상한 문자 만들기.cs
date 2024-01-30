public class Solution {
    public string solution(string s) {
        string answer = "";
        int num = 0;
        
        for(int i = 0; i < s.Length; ++i)
        {
            if(s[i] == ' ')
            {
                answer += s[i];
                num = 0;
                continue;
            }
            
            if(num%2 == 0)
                answer += s[i].ToString().ToUpper();
            else
                answer += s[i].ToString().ToLower();
            
            ++num;
        }
        
        return answer;
    }
}