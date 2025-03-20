using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] data, int col, int row_begin, int row_end) {
        int answer = 0;
        int[] bucket = new int[row_end - row_begin + 1];
        List<int[]> dataList = new List<int[]>();
        
        for(int i = 0; i < data.GetLength(0); ++i)
        {
            int[] temp = new int[data.GetLength(1)];
            for(int j = 0; j < temp.Length; ++j)
            {
                temp[j] = data[i,j];
            }
            dataList.Add(temp);
        }
        
        dataList.Sort((a,b) => 
                   {
                       int condition = a[col - 1].CompareTo(b[col - 1]);
                       if(condition == 0)
                           condition = b[0].CompareTo(a[0]);
                       return condition;
                   });
        
        for(int i = row_begin - 1; i < row_end; ++i)
        {
            int mod = i + 1; // 나눌 숫자
            for(int j = 0; j < dataList[0].Length; ++j)
            {
                bucket[i+1-row_begin] += dataList[i][j] % mod; 
            }
        }
        
        for(int i = 0; i < bucket.Length; ++i)
        {
            answer ^= bucket[i];
        }
        
        return answer;
    }
}