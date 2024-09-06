using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int x, int y, int n) {
        int answer = 0;
        
        answer = BFS(x,y,n);
        
        return answer;
    }
    
    public int BFS(int x, int y, int n)
    {
        if(x >= y) return 0;
        
        HashSet<int> visited = new HashSet<int>();
        Queue<(int val, int step)> queue = new Queue<(int, int)>();
        queue.Enqueue((x,0));
        visited.Add(x);
        
        while(queue.Count > 0)
        {
            (int val, int step) nowValue = queue.Dequeue();
            if(nowValue.val == y) // 꺼낸 값이 y와 동일
                return nowValue.step;
            
            //더하기n
            int addN = nowValue.val + n;
            if(!visited.Contains(addN) && addN <= y)
            {
                visited.Add(addN);
                queue.Enqueue((addN, nowValue.step + 1));
            }
                
            //곱하기2
            int mul2 = nowValue.val*2;
            if(!visited.Contains(mul2) && mul2 <= y)
            {
                visited.Add(mul2);
                queue.Enqueue((mul2, nowValue.step + 1));
            }
                
            //곱하기3
            int mul3 = nowValue.val*3;
            if(!visited.Contains(mul3) && mul3 <= y)
            {
                visited.Add(mul3);
                queue.Enqueue((mul3, nowValue.step + 1));
            }
                
        }
        
        return -1;
    }
}

// BFS로 풀어야하는데..
// 