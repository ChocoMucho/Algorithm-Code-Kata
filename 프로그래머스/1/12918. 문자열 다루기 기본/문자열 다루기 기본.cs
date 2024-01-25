public class Solution {
    public bool solution(string s) {
        bool answer = true;
        
        if(s.Length == 4 || s.Length == 6)
        {
            for(int i=0; i<s.Length; ++i)
            {
                if(s[i] < '0' || s[i] > '9')
                    return false;
            }
        }
        else
        {
            answer = false;
        }
        
        
        return answer;
    }
}