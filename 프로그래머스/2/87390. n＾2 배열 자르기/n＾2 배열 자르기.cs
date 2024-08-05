using System;

public class Solution {
    public int[] solution(int n, long left, long right) {
        int[] answer = new int[right - left + 1];
        int index = 0;
        
        for(long i = left/n; i < n; ++i)
        {
            if(i*n > right)
                break;
            for(long j = (left+index)%n; j < n; ++j)
            {
                if((i*n + j) > right)
                    break;
                
                long num = j+1;
                if(num <= i+1)
                    num = i+1;
                
                answer[index++] = (int)num;
            }
        }
        
        return answer;
    }
}
/*
n^2 전부 숫자 만드는 것 -> 시간 초과
left ~ right 사이만 순회하기
*/