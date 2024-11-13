using System;

public class Solution {
    public int solution(int[] arr) {
        if(arr.Length <= 1) return arr[0];
        
        int answer = LCM(arr[0], arr[1]);
        
        for(int i = 1; i < arr.Length-1; ++i)
        {
            answer = LCM(answer, arr[i+1]);
            Console.WriteLine(answer);
        }
        
        return answer;
    }
    
    public int LCM(int a, int b)
    {
        int m = a;
        int n = b;
        int r;
        while(n != 0)
        {
            r = m%n;
            m = n;
            n = r;
        }
        
        return (a*b) / m;
    }
}