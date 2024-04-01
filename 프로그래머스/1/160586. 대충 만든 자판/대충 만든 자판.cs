using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int sum = 0;
        
        
        for(int i = 0; i < targets.Length; ++i)
        {
            sum = 0;
            for(int j = 0; j < targets[i].Length; ++j)
            {
                int count = Press(keymap, targets[i][j]);
                if(-1 == count)
                {
                    sum = count;
                    break;
                }                    
                sum += count;
            }
            answer[i] = sum;
        }
        
        return answer;
    }
    
    public int Press(string[] keymap, char targetChar)
    {
        int pressedCount = -1;
        
        for(int i = 0; i < keymap.Length; ++i)
        {
            for(int j = 0; j < keymap[i].Length; ++j)
            {
                if(keymap[i][j] == targetChar)
                {
                    if(-1 == pressedCount)
                        pressedCount = ++j;
                    else if(pressedCount > j)
                        pressedCount = ++j;
                    break;
                }
                    
            }
        }
        
        
        return pressedCount;
    }
}