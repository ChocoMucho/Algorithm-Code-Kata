using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[] {50, 50, 0, 0};
        
        for(int i=0; i<wallpaper.Length; ++i)
        {
            for(int j=0; j<wallpaper[i].Length; ++j)
            {
                //1
                if(wallpaper[i][j] == '#')
                {   
                    // 1-1
                    answer[0] = answer[0] > i? i: answer[0];
                    answer[1] = answer[1] > j? j: answer[1];
                    //1-2
                    answer[2] = answer[2] <= i? i+1: answer[2];
                    answer[3] = answer[3] <= j? j+1: answer[3];
                }
            }
        }
        
        return answer;
    }
}

/*
각 데이터 처리 방법
-> #이면 최소(최대) x,y 구하기

배열 순회 = i
문자열 순회 = j
최소 x,y = 50
최대 x,y = 0

i => x / j => y

wallpaper의 요소(문자열)을 순회
{
1, #을 만남
1-1 최소 값이랑 비교해서 i나 j 둘 중에 미만이면 그대로 대입
1-2 최대 값이랑 비교해서 i나 j 둘 중에 이상이면 +1씩 대입
}
*/
