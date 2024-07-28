using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
        int length = elements.Length;
        HashSet<int> unique = new HashSet<int>();
        int[] buckets = new int[length];
        List<int> elementsToList = new List<int>(elements);
        
        for(int i = 0; i < length; ++i)
        {
            for(int j = 0; j < length; ++j)
            {
                buckets[j] += elementsToList[j];
                unique.Add(buckets[j]);
            }
            
            int temp = elementsToList[0];
            elementsToList.RemoveAt(0);
            elementsToList.Add(temp);
        }
        
        return unique.Count;
    }
}

/*
해시셋 변수 unique
n길이의 int 배열 buckets
앞 요소 뒤로 옮길 List elementsToList 

for(elements.Length => i)
{
    for(elements.Length => j)
    {
        buckets 각 요소마다 elementsToList[j]더해주기
        unique에 buckets[j] 추가하기
    }
    elementsToList 앞 요소 빼고 뒤로 붙이기
}

answer에 unique개수 대입 and answer반환
*/