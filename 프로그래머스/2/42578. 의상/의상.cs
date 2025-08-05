using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        Dictionary<string, int> clothCount = new Dictionary<string, int>();
        
        for(int i = 0; i < clothes.GetLength(0); ++i)
        {
            if(!clothCount.ContainsKey(clothes[i,1]))
                clothCount.Add(clothes[i,1], 1);
            else
                clothCount[clothes[i,1]] += 1;
        }
        
        foreach(KeyValuePair<string, int> kvp in clothCount)
        {
            answer *= (kvp.Value + 1);
        }
        
        return answer - 1;
    }
}

/*
딕셔너리<의상종류, 의상개수> => 정리
foreach(딕셔너리)
{
(n+1)을 곱해주기
}
결과값에서 1 빼주기
*/