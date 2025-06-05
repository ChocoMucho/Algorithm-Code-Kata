using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        Dictionary<string, int> wantDict = new Dictionary<string, int>();
        
        for(int i = 0; i < want.Length; ++i)
        {
            wantDict.Add(want[i], number[i]);
        }
        
        for(int i = 0; i <= discount.Length - 10; ++i)
        {
            Dictionary<string, int> windowDict = new Dictionary<string, int>();
            
            for(int j = 0; j < 10; ++j) // 비교용(슬라이드 윈도우) 딕셔너리 만들기
            {
                string temp = discount[j+i];
                if(windowDict.ContainsKey(temp))
                    ++windowDict[temp];
                else
                    windowDict.Add(temp, 1);
            }
            
            bool match = true;
            foreach(var kvp in wantDict)
            {
                if(!windowDict.ContainsKey(kvp.Key) || windowDict[kvp.Key] != kvp.Value)
                {
                    match = false;
                    break;
                }
            }
            if(match)
            {
                ++answer;
            }
        }
        
        return answer;
    }
}

/*
- want와 number의 딕셔너리 만들기
- 0부터 discount 길이 - 11 까지 순회 
    - wantDict처럼 딕셔너리 만들기 => windowDict
    - 순회 안쪽에서 wantDict와 windDict의 밸류 값이 동일한지 체크
O(n^2)인 것 같지만 일단 시도 
*/