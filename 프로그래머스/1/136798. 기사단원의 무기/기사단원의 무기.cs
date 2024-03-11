using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        
        for(int i = 1; i <= number; ++i)
        {
            int attack = DivisorCount(i);
            
            if(attack <= limit)
                answer += attack;
            else
                answer += power;
        }
        
        return answer;
    }
    
    public int DivisorCount(int num)
    {
        int count = 0;
        
        for(int i = 1; i * i <= num; ++i)
        {
            if(i * i == num)
                ++count;
            else if (num % i == 0)
                count += 2;
        }
        
        return count;
    }
}