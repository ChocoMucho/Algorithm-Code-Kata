public class Solution {
    public int solution(int num) {
        int answer = 0;
        long n = num;
        
        while(true)
        {
            if(n == 1) break;
            if(answer >= 500) return -1;
            
            n = n % 2 == 0 ? n / 2 : n * 3 + 1;
            
            ++answer;
        }
        
        return answer;
    }
}

/*
규칙
짝수는 2로 나누기
홀수는 3곱하고 1 더하기

1은 0, 500번 이상 반복 -> -1
*/