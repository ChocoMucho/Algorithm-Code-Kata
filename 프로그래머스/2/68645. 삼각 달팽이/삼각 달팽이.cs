using System;

public class Solution {
    public int[] solution(int n) {
        int length = (n * (n+1)) / 2;
        int[] answer = new int[length];
        int[,] twoDimens = new int[n,n];
        int x = -1;
        int y = 0;
        int num = 0;
        
        for(int i = 0; i < n; ++i)
        {
            for(int j = i; j < n; ++j)
            {
                if(i % 3 == 0)//좌하
                    ++x;
                else if(i % 3 == 1)//우
                    ++y;
                else if(i % 3 == 2)//좌상
                {
                    --x; 
                    --y;
                }                   
                
                twoDimens[x,y] = ++num;
            }
        }
        
        int index = 0;
        for(int i = 0; i < n; ++i)
        {
            for(int j = 0; j < n; ++j)
            {
                if(twoDimens[i,j] == 0)
                    break;
                answer[index++] = twoDimens[i,j];
            }
        }
        
        return answer;
    }
}
/* 
찾아낸 규칙
n = 4 기준
왼쪽 면 채울 때 4번 채움
아래 면 채울 때 3번 채움
오른 쪽 면 채울 때 2번 채움
다시 왼쪽 면 채울 때 1번 채움
4 -> 3 -> 2 -> 1

그리고 3면을 기준으로 하는 것이기 때문에
채우는 규칙이 3개가 나옴
좌하 - 우 - 좌상
이중 for문이면 i값에 따라서 좌하인지 우인지 좌상인지 구분이 가능하다.
*/