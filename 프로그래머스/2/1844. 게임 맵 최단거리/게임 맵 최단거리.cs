using System;
using System.Collections.Generic;

struct Node
{
    public int R;
    public int C;
    public int Dist;
    public Node(int r, int c, int dist)
    {
        R = r;
        C = c;
        Dist = dist;
    }
}

class Solution {
    public int solution(int[,] maps) {
        int answer = -1;
        Queue<Node> queue = new Queue<Node>();
        Node maxNode = new Node(maps.GetLength(0)-1, maps.GetLength(1)-1, 0);
        bool[,] visited = new bool[maps.GetLength(0), maps.GetLength(1)];
        
        queue.Enqueue(new Node(0,0,1));
        visited[0,0] = true;
        
        while(queue.Count > 0)
        {
            Node curNode = queue.Dequeue();
            
            if((curNode.R == maxNode.R) && (curNode.C == maxNode.C))
            {
                answer = curNode.Dist;
                break;
            }
            
            if(curNode.R > 0)//상
            {
                if(maps[curNode.R-1, curNode.C] == 1 && !visited[curNode.R-1, curNode.C])
                {
                    visited[curNode.R-1, curNode.C] = true;
                    queue.Enqueue(new Node(curNode.R-1, curNode.C, curNode.Dist+1));
                }
                    
            }
            if(curNode.R < maxNode.R)//하
            {   
                if(maps[curNode.R+1, curNode.C] == 1 && !visited[curNode.R+1, curNode.C])
                {
                    visited[curNode.R+1, curNode.C] = true;
                    queue.Enqueue(new Node(curNode.R+1, curNode.C, curNode.Dist+1));
                }
            }
            if(curNode.C > 0)//좌
            {   
                if(maps[curNode.R, curNode.C-1] == 1 && !visited[curNode.R, curNode.C-1])
                {
                    visited[curNode.R, curNode.C-1] = true;
                    queue.Enqueue(new Node(curNode.R, curNode.C-1, curNode.Dist+1));
                }
            }
            if(curNode.C < maxNode.C)//우
            {
                if(maps[curNode.R, curNode.C+1] == 1 && !visited[curNode.R, curNode.C+1])
                {
                    visited[curNode.R, curNode.C+1] = true;
                    queue.Enqueue(new Node(curNode.R, curNode.C+1, curNode.Dist+1));
                }
                    
            }
        }
        
        return answer;
    }
}

/*
maps 행렬 크기 가져오기 n,m
큐를 이용한 BFS
1. 빈 큐에 0,0 넣기 (데이터 형식은 뭐로?) => 구조체
2. while 문을 실행한다. 조건은 큐의 길이가 1이상이면 실행.
3. 큐에서 하나 빼와서 각 방향마다 체크를 한다.
3-1. 범위안에 드는지 확인한다. 1이면 큐에 넣고, 0이면 패스한다. 
4. n-1, m-1에 도달하면 이동 값을 반환한다.
*/