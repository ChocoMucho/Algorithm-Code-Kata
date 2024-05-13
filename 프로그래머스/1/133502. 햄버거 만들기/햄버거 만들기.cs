using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> temp = new List<int>();
        
        foreach(int element in ingredient)
        {
            temp.Add(element);
            if(temp.Count >= 4)
            {
                if(temp[temp.Count - 4] == 1 && temp[temp.Count - 3] == 2 && temp[temp.Count - 2] == 3 && temp[temp.Count - 1] == 1)
                {
                    temp.RemoveRange(temp.Count - 4, 4);
                    ++answer;
                }
            }
            
        }
        
        return answer;
    }
}

/*
리스트에 배열 요소를 하나씩 추가

*/