using System;

public class Solution {
    public int[] solution(string s) {        
        string source = s;
        int count = 0;
        int deleteZero = 0;
        
        while(true)
        {
            if(source.Length <= 1)
                break;
            
            int temp = 0;
            for(int i = 0; i < source.Length; ++i)
            {
                if(source[i] == '0')
                {
                    ++deleteZero;
                    ++temp;
                }
            }
            
            source = Convert.ToString(source.Length - temp, 2);
            
            ++count;
        }
        
        return new int[] {count, deleteZero};
    }
}