public class Solution {
    public string solution(string s) {
        string answer = "";
        
        char[] charArray = s.ToLower().ToCharArray();
        
        charArray[0] = char.ToUpper(charArray[0]);
        
        for(int i = 1; i < s.Length; ++i)
        {
            if(charArray[i - 1] == ' ')
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
        }
        
        answer = string.Join("", charArray);
        
        return answer;
    }
}