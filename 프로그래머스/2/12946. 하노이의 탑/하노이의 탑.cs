using System;
using System.Collections.Generic;

public class Solution {
    List<(int x, int y)> moveRecord = new List<(int,int)>();
    
    public int[,] solution(int n) {
        MoveHanoiTower(n, 1, 3, 2);
        int[,] answer = new int[moveRecord.Count,2];
        
        for(int i = 0; i < moveRecord.Count; ++i)
        {
            answer[i,0] = moveRecord[i].x;
            answer[i,1] = moveRecord[i].y;
        }
                
        return answer;
    }
    
    public void MoveHanoiTower(int length, int start, int end, int sub)
    {
        if(length == 1)
        {
            MoveRing(start, end);
            return;
        }            
        
        // 스타트 -> 서브
        MoveHanoiTower(length - 1, start, sub, end);
        // 스타트 -> 엔드 바로 MoveRing
        MoveRing(start, end);
        // 서브 -> 엔드
        MoveHanoiTower(length - 1, sub, end, start);
    }
    
    public void MoveRing(int start, int end)
    {
        moveRecord.Add((start, end));
    }
}

// n-1개의 원판이 움직임
// 맨 밑의 판이 움직임
// 일단 판 자체가 움직이는 함수 필요
// 찾아보니 3가지 단계가 필요함
// 1. 스타트 -> 서브 : 맨 밑을 제외한 모든게 서브로 감
// 2. 스타트 -> 엔드 : 맨 밑이 엔드로 감
// 3. 서브 -> 엔드 : 서브에 있던 것들이 전부 엔드로 감