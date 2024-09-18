using System;
using System.Collections.Generic;

public class Solution {
    private List<int> result = new List<int>();
    public int[] solution(string[] maps) 
    {
        int[] answer;
        BFS(maps);
        
        if(result.Count <= 0)
            answer = new int[] {-1};
        else
        {
            result.Sort();
            answer = result.ToArray();
        }      
        
        return answer;
    }
    
    private void BFS(string[] maps)
    {
        Queue<(int x, int y)> queue = new Queue<(int,int)>(); //BFS용 큐
        HashSet<(int, int)> visited = new HashSet<(int, int)>();    
        
        for (int i = 0; i < maps.Length; ++i)
        {
            for (int j = 0; j < maps[i].Length; ++j)
            {
                if (visited.Contains((i, j)) || maps[i][j] == 'X') // 방문,X확인
                    continue;
                queue.Enqueue((i, j));
                visited.Add((i, j));
                int addResult = 0;

                while (queue.Count > 0) // 하,좌,우 붙은 곳 확인하기
                {
                    (int x, int y) now = queue.Dequeue();
                    addResult += int.Parse(maps[now.x][now.y].ToString()); // 꺼낸 값 더해주기

                    //상
                    int up = now.x - 1;
                    if(up >= 0)
                    { //범위 체크
                        if(!visited.Contains((up, now.y)) && maps[up][now.y] != 'X')
                        {
                            visited.Add((up, now.y));
                            queue.Enqueue((up, now.y));
                        }
                    }
                    
                    //하
                    int down = now.x + 1;
                    if (down < maps.Length)
                    { //범위 체크
                        if (!visited.Contains((down, now.y)) && maps[down][now.y] != 'X')
                        {
                            visited.Add((down, now.y));
                            queue.Enqueue((down, now.y));
                        }
                    }

                    //좌
                    int left = now.y - 1;
                    if (left >= 0)
                    { //범위 체크
                        if (!visited.Contains((now.x, left)) && maps[now.x][left] != 'X')
                        {
                            visited.Add((now.x, left));
                            queue.Enqueue((now.x, left));
                        }
                    }

                    //우
                    int right = now.y + 1;
                    if (right < maps[0].Length)
                    { //범위 체크
                        if (!visited.Contains((now.x, right)) && maps[now.x][right] != 'X')
                        {
                            visited.Add((now.x, right));
                            queue.Enqueue((now.x, right));
                        }
                    }
                }

                result.Add(addResult);
            }
        }
    }
}

// 전체 탐색 한 번 하면서 가본 적 없으면 너비 우선 탐색?
// 어차피 다 훑으니까 while문 안에서 '상'은 볼 필요 없을듯