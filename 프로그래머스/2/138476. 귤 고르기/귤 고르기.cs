using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        List<int> tangCount = new List<int>();
        int max = tangerine.Max();
        
        for(int i = 0; i <= max; ++i)
        {
            tangCount.Add(0);
        }
        
        // 리스트화 하고 내림차순으로 정렬한다.
        for(int i = 0; i < tangerine.Length; ++i)
        {
            tangCount[tangerine[i]] += 1;
        }
        tangCount.Sort(new Comparison<int>((n1, n2) => n2.CompareTo(n1)));
        
        // 종류, 총 개수 체크하며 오버되는 순간에 종류를 정답으로 한다.
        int type = 0;
        int total = 0;
        for(int i = 0; i < tangCount.Count; ++i)
        {
            ++type;
            total += tangCount[i];
            if(total >= k)
            {
                answer = type;
                break;
            }
        }
        
        return answer;
    }
}