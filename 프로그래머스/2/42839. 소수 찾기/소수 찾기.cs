using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {   
    public int solution(string numbers) {
        int answer = 0;
        bool[] visited = new bool[numbers.Length];
        List<int> nums = new List<int>(); // 원본 다 자른거
        List<int> result = new List<int>();
        Queue<(int, bool[])> queue = new Queue<(int, bool[])>();
        
        for(int i = 0; i < numbers.Length; ++i) // 원본 자르기
        {
            nums.Add(int.Parse(numbers[i].ToString()));
        }
        
        // 큐 세팅 겸 소수 찾기
        for(int i = 0; i < nums.Count; ++i)
        {
            if(IsPrime(nums[i]))
                result.Add(nums[i]);
            bool[] copyVisit = (bool[])visited.Clone();
            copyVisit[i] = true;
            queue.Enqueue((nums[i], copyVisit));
        }
        
        while(queue.Count > 0)
        {
            (int n, bool[] visited) deq = queue.Dequeue();
            for(int i = 0; i < nums.Count; ++i)
            {
                if(deq.visited[i])
                    continue;
                
                int n = deq.n * 10 + nums[i];
                
                if(IsPrime(n))
                    result.Add(n);                    
                
                bool[] copy = (bool[])deq.visited.Clone();
                copy[i] = true;
                queue.Enqueue((n, copy));
            }
        }
        
        
        result = result.Distinct().ToList();
        
        return result.Count;
    }
    
    
    public bool IsPrime(int n)
    {
        if(n == 2)
            return true;
        if(n <= 1 || n%2 == 0)
            return false;      
        for(int i = 2; i*i <= n; ++i)
        {
            if(i*i == n || n%i == 0)
                return false;
        }
        
        return true;
    }
}