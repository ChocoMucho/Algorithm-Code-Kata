using System;
public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];
        
        for(int i = 0; i < arr1.GetLength(0); ++i)
        {
            for(int j = 0; j < arr1.GetLength(1); ++j)
            {
                answer[i,j] = arr1[i, j] + arr2[i,j];
            }
        }
        
        return answer;
    }
}
/*
[1,2]    [3,4]
[2,3]    [5,6]
...
[1+3, 2+4]
[2+5, 3+6]

@안쪽 배열의 길이는 바깥 배열의 길이와 동일함 -> 행렬 계산법
@문제에서 행과 열의 크기가 같은 두 행렬이라고 함
*/