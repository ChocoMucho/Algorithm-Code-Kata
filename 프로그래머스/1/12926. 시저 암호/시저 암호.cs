public class Solution {
    public string solution(string s, int n) {
        char[] charArr = s.ToCharArray();
        
        for(int i = 0; i < s.Length; ++i)
        {
            if(charArr[i] == ' ') continue;
            
            int num = (int)charArr[i] + n;
            
            if(charArr[i] >= 'A' && charArr[i] <= 'Z')
            {
                if(num > 'Z')
                    num -= 26;
            }
            else
            {
                if(num > 'z')
                    num -= 26;
            }
            
            charArr[i] = (char)num;
        }
        
        return new string(charArr);
    }
}