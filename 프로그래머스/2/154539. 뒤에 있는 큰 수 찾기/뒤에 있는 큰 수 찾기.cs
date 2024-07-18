using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int length = numbers.Length;
        int[] answer = new int[length];
        Stack<int> stack = new Stack<int>();
        
        for(int i = 0; i < length; ++i)
        {
            answer[i] = -1;
            int n = numbers[i];
            
            while(stack.Count > 0)
            {
                if(numbers[stack.Peek()] < n)
                {
                    answer[stack.Peek()] = n;
                    stack.Pop();
                }
                else
                    break;
                    
            }
            
            stack.Push(i);
        }
        
        return answer;
    }
}

// 인덱스들을 쌓음
// 지금 인덱스의 요소를 꺼내봄
// 앞에 쌓인 인덱스들의 요소들과 비교를 해봄