using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int k, int[] enemy) {
        int answer = 0;
        
        SortedDictionary<int, int> enemySortDic = new SortedDictionary<int, int>();
        
        if(k >= enemy.Length)
            return enemy.Length;
        
        // [2,1] [4,2]
        for(int i = 0; i < k; ++i) // enemy에서 k
        {
            if(!enemySortDic.ContainsKey(enemy[i]))
                enemySortDic[enemy[i]] = 1;
            else
                ++enemySortDic[enemy[i]];
            
            ++answer;
        }
        
        for(int i = k; i < enemy.Length; ++i)
        {
            var smallest = enemySortDic.First();

            //enemySortDic의 가장 작은 키(이하 "smallest.Key")
            //smallest.Key와 enemy[i] 둘 중 누가 더 작은지
            //smallest.Key가 enemy[i]의 미만인 경우
            if(smallest.Key < enemy[i])
            {
                n -= smallest.Key;

                if(!enemySortDic.ContainsKey(enemy[i]))
                    enemySortDic[enemy[i]] = 1;
                else
                    ++enemySortDic[enemy[i]];

                --enemySortDic[smallest.Key];
                if(enemySortDic[smallest.Key] <= 0)
                    enemySortDic.Remove(smallest.Key);                                       
            }
            else // smallest.Key가 enemy[i]이상인 경우
                n -= enemy[i];           
            
            if(n < 0)
                break;
            ++answer;
        }
        
        return answer;
    }
}

// 일단 k랑 enemy의 길이가 같으면 결과값은 k가 됨
// 1) enemy에서 제일 큰 수 k개에만 무적권 발동
// 2) n이 간당간당하면 1)을 무시