using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 1;
        int valueA = a;
        int valueB = b;
        
        while(true)
        {
            if(HalfValueRounded(valueA) == HalfValueRounded(valueB))
                return answer;
            
            valueA = HalfValueRounded(valueA);
            valueB = HalfValueRounded(valueB);
            
            ++answer;
        }
        

        return answer;
    }
    
    public int HalfValueRounded(int number)
    {
        return (number + 1) / 2;
    }
}