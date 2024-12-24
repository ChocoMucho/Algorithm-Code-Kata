using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] order) {
        int result = 0;
        Queue<int> mainQueue = new Queue<int>();
        Stack<int> subStack = new Stack<int>();
        
        for(int i = 1; i <= order.Length; ++i)
        {
            mainQueue.Enqueue(i);
        }
        
        while(true)
        {
            if(mainQueue.Count <= 0 && subStack.Count <= 0)
                break;
            // 1. 메인 peek이 맞음
            // 1-1. Dequeue하고 ++result
            // 2. 메인 peek이 아님
            // 2-1. 서브 peek해봄
            // 2-2. 서브 peek 맞으면 Pop하고 ++result
            // 2-3. 서브 peek 아니면 break;
            if(mainQueue.Count > 0 &&  mainQueue.Peek() == order[result])
            {
                mainQueue.Dequeue();
                ++result;
                continue;
            }
            else
            {
                if(subStack.Count > 0 && subStack.Peek() == order[result])
                {
                    subStack.Pop();
                    ++result;
                    continue;
                }
                else
                {
                    if(mainQueue.Count > 0)
                        subStack.Push(mainQueue.Dequeue());
                    else
                        break;
                }                
            }
        }
        
        return result;
    }
}