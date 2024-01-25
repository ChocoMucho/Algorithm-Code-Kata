public class Solution {
    public bool solution(string s) {
        bool answer = true;
        
        for(int i=0; i<s.Length; ++i)
        {
            if(s[i] < '0' || s[i] > '9')
                return false;
        }
        
        return answer;
    }
}