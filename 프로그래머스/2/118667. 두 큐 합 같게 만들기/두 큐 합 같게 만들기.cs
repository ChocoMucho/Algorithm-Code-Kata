using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] queue1, int[] queue2) {
        int answer = 0;
        long sum1 = 0;
        long sum2 = 0;
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        
        foreach(int item in queue1)
        {
            sum1 += item;
            q1.Enqueue(item);
        }
        
        foreach(int item in queue2)
        {
            sum2 += item;
            q2.Enqueue(item);
        }
        
        if((sum1 + sum2) % 2 != 0) // 2로 나누어져야함
            return -1;
        
        while(sum1 > 0 && sum2 > 0)
        {
            if(sum1 == sum2) break;
            int temp = 0;
            if(sum1 > sum2)
            {
                temp = q1.Dequeue();
                sum1 -= temp;
                sum2 += temp;
                q2.Enqueue(temp);
            }
            else if(sum1 < sum2)
            {
                temp = q2.Dequeue();
                sum2 -= temp;
                sum1 += temp;
                q1.Enqueue(temp);
            }
            
            ++answer;
            
            if(q1.Count <= 0||q2.Count <= 0)
                return -1;          
            
            if(answer >= 999999) // 아니 이게 왜 돼..
                return -1;
        }
        
        return answer;
    }
}

/*
예상 솔루션 1. 큐1 큐2 비교하면서 하나씩 빼서 옮기기

*/