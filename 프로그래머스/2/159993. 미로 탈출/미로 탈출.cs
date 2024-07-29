using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] maps) {        
        (int x, int y) S;
        (int x, int y) L;
        
        int distToL = 0;
        int distToE = 0;
        
        for(int i = 0; i < maps.Length; ++i)
        {
            for(int j = 0; j < maps[0].Length; ++j)
            {
                if(maps[i][j] == 'S')
                    S = (i,j);
                if(maps[i][j] == 'L')
                    L = (i,j);
            }
        }
        
        distToL = BFS(maps, S, 'L');
        if(distToL == -1)
            return -1;
        
        distToE = BFS(maps, L, 'E');
        if(distToE == -1)
            return -1;
        
        return distToL + distToE;
    }
    
    private int BFS(string[] maps, (int x, int y) start, char dest)
    {
        int[ , ] record = new int[maps.Length, maps[0].Length]; // 지나간 곳 체크&&거리 측정
        int[ , ] direction = new int[,]{ {-1,0}, {1,0}, {0,-1}, {0,1} }; // 방향
        Queue<(int, int)> queue = new Queue<(int, int)>(); // 너비 우선 탐색용 큐
        
        queue.Enqueue(start);
        
        while(queue.Count > 0)
        {
            // 큐에서 하나 꺼내기
            (int x, int y) curPoint = queue.Dequeue();            
            
            //목표지점 도달했는지 확인
            if(maps[curPoint.x][curPoint.y] == dest)
                return record[curPoint.x, curPoint.y];
            
            // direction 순회하면서 진행 가능한 좌표 큐에 넣기
            for(int i=0; i < 4; ++i)
            {
                int x = curPoint.x + direction[i, 0];
                int y = curPoint.y + direction[i, 1];
                
                // x,y 범위 체크
                if(x >= maps.Length || x < 0)
                    continue;
                if(y >= maps[0].Length || y < 0)
                    continue;
                
                // 진행하려는 곳이 벽(X)인지
                if(maps[x][y] == 'X')
                    continue;
                // 지나간 곳인지 -> 0이 아닌 경우
                if(record[x, y] != 0)
                    continue;
                
                // Enqueue / 1 증가한 값으로 record에 기록
                queue.Enqueue((x,y));
                record[x,y] = record[curPoint.x,curPoint.y] + 1;
            }
        }
        
        return -1;
    }
}