using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
        int answer = 0;
        HashSet<int> unique = new HashSet<int>();
        List<int> list = new List<int>();
        int[] basket = new int[elements.Length];
        
        int length = elements.Length;
        
        for(int i = 0; i < length; ++i)
        {
            list.Add(elements[i]);
        }
        
        for(int i = 1; i <= length - 1; ++i)
        {
            for(int j = 0; j < length; ++j)
            {
                basket[j] += list[j];
                unique.Add(basket[j]);
            }
            int temp = list[length - 1];
            list.Insert(0, temp);
        }
        
        answer = unique.Count;
        ++answer;
        
        return answer;
    }
}

/*
@ 중복 제외하는 컬렉션 준비 -> 해시셋
@ 길이 N만큼 요소들을 합쳐야 함. 배열 길이 넘으면 0부터 진행
@ N은 배열의 길이를 넘어서지 않음
@ elements의 길이와 같을 때에는 그냥 answer 증가 한번 -> 유일함

해시셋 unique
리스트 list = elements의 요소들
배열 basket = elements의 길이 만큼 선언

for(i, 1 부터 elements.Length - 1)
{
    for(j, elements.Length)
    {
        basket[j] += list[j]
        unique.Add(basket[j])
    }
    
    temp = list 마지막 요소
    list에서 마지막 요소 제거
    list 맨 앞에 temp 삽입
}
answer = 유니크 요소 개수
++answer
*/