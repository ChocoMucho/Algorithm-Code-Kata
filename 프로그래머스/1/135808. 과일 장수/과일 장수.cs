using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        
        Array.Sort(score);
        Array.Reverse(score);
        
        for(int i = m - 1; i < score.Length; i += m)
        {
            answer += score[i] * m;
        }
        
        return answer;
    }
}

/*
각 상자마다 제일 낮은 점수 기준이기 때문에
한 상자에 낮은 점수들을 몰아줘야 한다. -> 내림차순 정렬(Sort, Reverse)
[1,2,3,1,2,3,1]->(내림차순 정렬)->[3,3,2,2] [1,1,1] 
-> 2점짜리 상자, 1점짜리는 버리기
2점 * m * 온전한 상자 1개 => 8의 이익
*/