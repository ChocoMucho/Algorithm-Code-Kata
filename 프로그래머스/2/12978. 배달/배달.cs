using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int N, int[,] roads, int K)
    {
        int answer = 0;
        var graph = new Dictionary<int, List<Tuple<int, int>>>();
        int[] dist = new int[N+1]; // 방문 체크 겸 드는 시간
        Queue<(int node, int cost)> queue = new Queue<(int,int)>();
        
        for(int i = 1; i <= N; ++i){
            graph[i] = new List<Tuple<int, int>>();
        }
        
        for(int i = 1; i <=N; ++i){
            dist[i] = 999999;
        }
        
        for(int i = 0; i < roads.GetLength(0); ++i)
        {
            int a = roads[i,0];
            int b = roads[i,1];
            int c = roads[i,2];
            graph[a].Add(new Tuple<int, int>(b, c));
            graph[b].Add(new Tuple<int, int>(a, c));
        }
        
        queue.Enqueue((1,0));
        dist[1] = 0; // 1까지 가는 길은 0의 시간
        while(queue.Count > 0) //BFS 시작
        {
            (int node,int cost)curNode = queue.Dequeue();
            List<Tuple<int,int>> curList = graph[curNode.node];//graph의 리스트 가져오기            
            foreach(var next in curList)
            {
                if(dist[curNode.node] + next.Item2 < dist[next.Item1])
                {
                    dist[next.Item1] = dist[curNode.node] + next.Item2;
                    queue.Enqueue((next.Item1, next.Item2));
                }
            }
        }
        
        for(int i = 1; i < dist.Length; ++i)
        {
            if(dist[i] <= K)
                ++answer;
        }
        
        return answer;
    }
}