using System;

public class Solution {
    public int[] solution(int[] sequence, int k) {
        int[] answer = new int[]{0,999999};
        int start = 0;
        int end = 0;
        int sum = sequence[0];
        
        while(start < sequence.Length)
        {
            if(sum == k) // start 부터 end 까지의 합이 k와 같을 때
            {
                if((end-start) < (answer[1]-answer[0])) // 기존 s~e가 더 클 때
                {
                    answer[0] = start;
                    answer[1] = end;
                }
                
                if(++end >= sequence.Length)
                    break;
                else
                    sum += sequence[end];            
            }
            else if(sum < k)
            {
                if(++end >= sequence.Length)
                    break;
                else
                    sum += sequence[end];   
            }
            else if(sum > k)
            {
                sum -= sequence[start++];
            }
        }
        
        return answer;
    }
}