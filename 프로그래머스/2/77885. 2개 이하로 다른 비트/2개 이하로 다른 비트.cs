using System;

public class Solution {
    public long[] solution(long[] numbers) {
        int length = numbers.Length;
        long[] answer = new long[length];
        
        for(int i = 0; i < length; ++i)
        {
            answer[i] = Calculate(numbers[i]);
        }
        
        return answer;
    }
    
    public long Calculate(long number)
    {
        long compared = number + 1;
        int diffValue = -1;
        
        if(number%2 == 0) //짝수
            return number+1;
        else //홀수
        {
             string binary = Convert.ToString(number, 2);
            int idx = binary.LastIndexOf("0");
            if(idx == -1) // 1로만 가득찼다면
            {
                binary = "10" + binary.Substring(1);
            }
            else // 중간에 0이 존재한다면
            {
                binary = binary.Substring(0,idx) + "10" + binary.Substring(idx+2);
            }//ex) 10101 => 10110
            
            return Convert.ToInt64(binary,2);
        }
    }
}