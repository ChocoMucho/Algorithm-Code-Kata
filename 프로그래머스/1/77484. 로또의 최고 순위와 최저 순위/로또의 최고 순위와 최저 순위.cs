using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[] {0,0};
        
        int min = 0;
        int max = 0;
        
        for(int i = 0; i < lottos.Length; ++i)
        {
            if(lottos[i] == 0)
            {
                ++max;
                continue;
            }                
                
            for(int j = 0; j < win_nums.Length; ++j)
            {
                if(lottos[i] == win_nums[j])
                {
                    ++max;
                    ++min;
                }                    
            }
        }     
        
        answer[0] = max >= 1 ? 7 - max : 6;
        answer[1] = min >= 1 ? 7 - min : 6;
        
        return answer;
    }
}