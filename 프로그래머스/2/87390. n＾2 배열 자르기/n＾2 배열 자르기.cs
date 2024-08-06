using System;

public class Solution {
    public int[] solution(int n, long left, long right) {
        int[] answer = new int[right - left + 1];
        int index = 0;
        
        // left/n는 잘라낼 부분이 시작하는 행을 가리킴        
        for(long i = left/n; i < n; ++i)
        {
            if(i*n > right)
                break;
            
            // (left+index)%n는 현재 행 내의 열을 가리킴  
            for(long j = (left+index)%n; j < n; ++j)
            {
                if((i*n + j) > right) //지금 가리키는 위치가 right범위를 벗어났나
                    break;
                
                long num = j+1;
                // 현재 열이 현재 행 이하라면 행의 값을 사용
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