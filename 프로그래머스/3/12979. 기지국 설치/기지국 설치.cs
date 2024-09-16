using System;

class Solution
{
    public int solution(int n, int[] stations, int w){
        int answer =0;
        int lastCovered = 0;
        int stationCover = (w*2) + 1;
        int needCover = 0;
        
        for(int i = 0; i < stations.Length; ++i) //덮이는 범위
        {
            int station = stations[i];    //9
            int start = Math.Max(1, station - w); //7
            int end = Math.Min(n, station + w); //11
            
            needCover = start - lastCovered - 1; // 커버할 공간 계산 //7-0-1=6
            if(needCover >= 1) // 커버할 공간이 1개 이상
                answer += (needCover + stationCover - 1) / stationCover; // (6/5)+1=2
            
            lastCovered = end; //11
        }
        
        //나머지 남은 공간
        if(lastCovered < n)
        {
            needCover = n - lastCovered; //16-11=5
            answer += (needCover + stationCover - 1) / stationCover;
        }
             

        return answer;
    }
}
// 