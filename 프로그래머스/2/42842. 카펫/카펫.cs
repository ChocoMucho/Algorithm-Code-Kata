using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[] {0,0};
        int total = brown + yellow;
        int x = 0;
        int y = 0;
        
        for(int i = 1; i*i <= total; ++i)
        {
            if((float)total % (float)i != 0)
                continue;
            x = (int)(total/i);
            y = i;
            int result = total - ((x*2)+(y*2)-4);
            if(result == yellow)
                break;
        }
        
        answer[0] = x;
        answer[1] = y;
        
        return answer;
    }
}