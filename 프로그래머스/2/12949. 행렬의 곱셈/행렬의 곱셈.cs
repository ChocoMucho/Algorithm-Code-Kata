using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        // 결과물의 행과 열은 arr1의 행, arr2의 열의 길이를 따름
        int[,] answer = new int[arr1.GetLength(0),arr2.GetLength(1)];
        
        for(int i = 0; i < arr1.GetLength(0); ++i)
        {
            for(int j = 0; j < arr1.GetLength(1); ++j)
            {
                for(int k = 0; k < arr2.GetLength(1); ++k)
                {
                    answer[i,k] += arr1[i,j] * arr2[j,k];
                }
            }
        }
        
        return answer;
    }
}

/*
A
[a1 b1 c1]
[d1 e1 f1]
----------
B
[a2 b2]
[c2 d2]
[e2 f2]

AxB
[a1a2+b1c2+c1e2 a1b2+b1d2+c1f2]
[d1a2+e1c2+f1e2 d1b2+e1d2+f1f2]

A의 1번째 행의 요소들을 B의 1번째 요소들과 곱하고 다 더함
A의 1번째 행의 요소들을 B의 2번째 요소들과 곱하고 다 더함

A의 2번째 행의 요소들을 B의 1번째 요소들과 곱하고 다 더함
A의 2번째 행의 요소들을 B의 2번째 요소들과 곱하고 다 더함
*/