using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        int[] temp;
        
        for(int i = 0; i < commands.GetLength(0); ++i)
        {
            int length = commands[i,1] - commands[i,0] + 1;
            temp = new int[length];
            
            Array.Copy(array, commands[i,0] - 1, temp, 0, length);
            Array.Sort(temp);
            answer[i] = temp[commands[i,2] - 1];
        }
        
        return answer;
    }
}
/*
1. 자르고
2. 정렬하고
3. 고르고

@ answer의 크기를 commands의 행 길이로 넣지 않고 array의 길이로 넣었었음
@ Copy의 두 번째 인자에 인덱스 위치를 넣어야하는데 1이 큰 값을 넣어서 범위를 벗어났었음
*/