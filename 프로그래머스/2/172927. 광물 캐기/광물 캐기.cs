using System;

public class Solution {
    public int solution(int[] picks, string[] minerals) {
        int answer = int.MaxValue;
        int[,] pickMineralMap = new int[,] {{1,1,1},{5,1,1},{25,5,1}};
        int[] mineralValue = new int[minerals.Length];
        
        for(int i = 0; i < minerals.Length; ++i)
        {
            switch(minerals[i]) 
            {
                case "diamond": mineralValue[i] = 0;break; 
                case "iron": mineralValue[i] = 1;break; 
                case "stone": mineralValue[i] = 2;break; 
                default: break;
            }
        }
        
        DFS(ref answer, picks, mineralValue, pickMineralMap, 0, 0);
        
        return answer;
    }
    
    // n : 광물 인덱스, fatigue : 누적 피로도
    public void DFS(ref int answer, int[] picks, int[] mineralValue, int[,] pickMineralMap, int n, int fatigue)
    {
        // 광물 다 캠(곡괭이 알맞게 다 쓰거나 남음)
        if(mineralValue.Length <= n) 
        {
            if(answer > fatigue) answer = fatigue;// 더 적은 피로도 대입
        }
        
        bool IsNoPick = true;
        // 광물 캐기
        for(int i = 0; i < 3; ++i) // 곡괭이 종류만큼
        {
            if(picks[i] <= 0)
                continue;
            
            IsNoPick = false;
            
            int tempFatigue = 0;
            for(int j = 0; j < 5; ++j) // 곡괭이당 5번 광질
            {
                if(n + j >= mineralValue.Length) break; // 광물 다 씀
                int mineral = mineralValue[n + j];
                tempFatigue += pickMineralMap[i, mineral];
            }
            
            --picks[i];
            DFS(ref answer, picks, mineralValue, pickMineralMap, n + 5, fatigue + tempFatigue);
            ++picks[i]; // 이 다음 곡괭이로 넘어갈 때 얘를 안 썼다고 가정해야해서 복구시킴
        }
        
        // 곡괭이 다 쓴 경우
        if(IsNoPick)
        {
            if(answer > fatigue) answer = fatigue;// 더 적은 피로도 대입
        }
    }
}
/*
@ 한 번 집은 곡괭이는 5개를 캐야함
@ 돌 곡괭이로 다이아 캘 때가 가장 최악임
@ 그냥 DFS로 찍어버리기



*/