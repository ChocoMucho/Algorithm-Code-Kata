public class Solution {
    public string[] solution(string[] strings, int n) {
        for(int i = 0; i < strings.Length - 1; ++i)
        {
            int tmp = i;
            for(int j = i+1; j < strings.Length; ++j)
            {
                if(strings[tmp][n] == strings[j][n])
                    tmp = string.Compare(strings[tmp], strings[j]) >= 1 ? j : tmp;
                else if(strings[tmp][n] > strings[j][n])
                    tmp = j;
            }
            
            string tmpStr = strings[i];
            strings[i] = strings[tmp];
            strings[tmp] = tmpStr;
        }
        
        
        
        return strings;
    }
}