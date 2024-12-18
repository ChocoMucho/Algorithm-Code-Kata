using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers, int target) {
        int answer = 0;
        Queue<(int accum, int index)> queue = new Queue<(int, int)>();
          
        queue.Enqueue((0,0));
        while(0 < queue.Count)
        {
            (int a, int b) temp = queue.Dequeue();
            int accum = temp.a;
            int index = temp.b;
            
            if(index >= numbers.Length)
            {
                if(accum == target)
                    ++answer;
                continue;
            }                
            
            // +랑 - 둘 다 넣어주기
            queue.Enqueue((accum+numbers[index], index+1));
            queue.Enqueue((accum-numbers[index], index+1));
        }
        
        return answer;
    }
}