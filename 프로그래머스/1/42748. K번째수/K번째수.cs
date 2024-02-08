using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        for(int i = 0; i < commands.GetLength(0); ++i)
        {
            int a = commands[i, 0]; //시작 지점
            int b = commands[i, 1]; //끝 지점
            int c = commands[i, 2]; //가리킬 지점
            
            int[] temp = new int[b - a + 1]; // 잘라낼 부분 담을 배열
            
            for(int n = 0; n < temp.Length; ++n)
            {
                temp[n] = array[(a-1)+n];
            }
            
            Array.Sort(temp);
            
            answer[i] = temp[c-1];
        }
        
        return answer;
    }
}