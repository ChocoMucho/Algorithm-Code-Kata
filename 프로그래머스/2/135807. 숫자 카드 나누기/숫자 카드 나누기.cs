using System;

public class Solution {
    public int solution(int[] handA, int[] handB) {
        int answer = 0;
        int length = handA.Length;
        
        if(length <= 1)
            return handA[0] == handB[0] ? 0 : Math.Max(handA[0], handB[0]);
        
        int a = CompareHand(handA, handB, length);
        int b = CompareHand(handB, handA, length);
        
        answer = a >= b ? a : b ;
        
        return answer;
    }
    
    public int CompareHand(int[] handA, int[] handB, int length)
    {
        int standard = handA[0];
        
        for(int i = 1; i < length; ++i) // 모든 것에 대한 GCD를 구해야 했음.
        {
            standard = GCD(standard, handA[i]);
        }
        
        for(int i = 0; i < length; ++i) //handA 다 나눠지는지 확인
        {
            if(handA[i] % standard != 0)
                return 0;
        }
        
        for(int i = 0; i < length; ++i) //handB 하나라도 나눠지는지 확인
        {
            if(handB[i] % standard == 0)
                return 0;
        }
        
        return standard;
    }
    
    public int GCD(int x, int y) // 유클리드 호제법
    {
        while(y != 0)
        {
            int temp = y;
            y = x%y;
            x = temp;
        }
        return x;
    }
}

/* 각 배열 우선 정렬
===배열 A와 B를 받는 함수===
배열 A의 0,1 요소의 최대 공약수 구함
최대 공약수 안구해지면 그냥 0리턴
A 전체가 나눠지는지 확인
B 전체가 안나눠지는지 확인

두 조건 다 되면 최대공약수 리턴
하나라도 안되면 0리턴

===유클리도 호제법 함수===
최대 공약수 겟
*/