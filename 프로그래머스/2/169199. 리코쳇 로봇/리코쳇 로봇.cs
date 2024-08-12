using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] board) {
        int answer = 0;
        (int x, int y) start;
        for(int i = 0; i < board.Length; ++i)
        {
            for(int j = 0; j < board[i].Length; ++j)
            {
                if(board[i][j] == 'R')
                    start = (j,i);
            }
        }
        
        answer = BFS(board, start);
        
        return answer;
    }
    
    public int BFS(string[] board, (int x, int y)start)
    {
        int[,] direction = new int[,]{{0,-1},{0,1},{-1,0},{1,0}};
        int[,] record = new int[board.Length, board[0].Length];
        Queue<(int, int)> queue = new Queue<(int, int)>();
        
        queue.Enqueue(start);
        
        while(queue.Count > 0)
        {
            (int x, int y) curPoint = queue.Dequeue();
            int curRecord = record[curPoint.y, curPoint.x];
            
            if(board[curPoint.y][curPoint.x] == 'G')
                return record[curPoint.y, curPoint.x];
            
            for(int i = 0; i < 4; ++i)
            {
                int x = curPoint.x;
                int y = curPoint.y;
                
                while(true)
                {
                    int nextX = x + direction[i,0];
                    int nextY = y + direction[i,1];
                    //범위 체크, 벽(D)만났는지
                    if(nextX < 0 || nextX >= board[0].Length) break;
                    if(nextY < 0 || nextY >= board.Length) break;
                    if(board[nextY][nextX] == 'D') break;
                    //진행 가능
                    x = nextX;
                    y = nextY;
                }
                
                // 진행 없었으면 바로 방향 전환
                if(x == curPoint.x && y == curPoint.y)
                    continue;
                
                // 가본 곳 아니면 기록 값 증가
                if(record[y,x] == 0)
                {
                    queue.Enqueue((x,y));
                    record[y,x] = curRecord + 1;
                }
            }
        }
        
        return -1;
    }
}