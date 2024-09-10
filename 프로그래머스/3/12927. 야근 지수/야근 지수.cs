using System;

public class Solution {
    public long solution(int n, int[] works) {
        long answer = 0;
        
        Array.Sort(works);
        
        for(int i = 0; i < n; ++i)
        {
            int index = works.Length - 1; // 맨 뒤에서부터
            
            while(index > 0 && works[index] <= works[index - 1])
            {
                --index;
            }
            
            if(works[index] == 0) return 0;
            --works[index];
        }
        
        for(int i = 0; i < works.Length; ++i)
        {
            answer += works[i] * works[i];
        }
        
        return answer;
    }
}
// 전체가 같이 줄어드는게 중요해보임
/*
접근 1)
works 길이 length
works 원소들 다 더함 => summary //5
거기에 n을 뺌 => summary -= n //4
summary를 works 길이로 나눔, 나머지도 => quotient, remainder //1, 1

(length - remainder)*(quotient * quotient)
+
remain * ((quot+1) * (quot+1))

실패 원인
원소간의 차이가 많이 날 때에 오답이 나온다
[7, 1, 1, 1], 4
내 방식 => 10
문제의 방식 => 12
*/

/*
접근 2)
그냥 n만큼 순회하면서 빼보는 방법
*/