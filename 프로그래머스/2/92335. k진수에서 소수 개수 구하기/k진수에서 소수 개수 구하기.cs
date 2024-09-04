using System;
using System.Linq;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        
        string[] numsString = new string[]{};
        numsString = Convert(n,k).Split('0');//잘라 넣기
        
        foreach(string num in numsString)
        {
            if(!string.IsNullOrEmpty(num) && IsPrime(long.Parse(num)))
                ++answer;
        }
        
        return answer;
    }
    
    public string Convert(int n, int baseValue)
    {
        if(baseValue == 10) return n.ToString();
        
        int remain = 0;
        string tempString = "";        
        
        while(n > 0) // 여기가 잘못되지 않았을까.
        {
            remain = n % baseValue;
            tempString += remain.ToString();
            n /= baseValue;
        }
        
        string valueString = new string(tempString.Reverse().ToArray());
        
        return valueString;
    }
    
    public bool IsPrime(long num)// 소수 판별
    {
        if(num == 1) return false; // 0과 1 제외
        if(num == 2) return true; // 2는 소수
        
        for(long i = 3; i * i <= num; ++i)
        {
            if(num % i == 0) return false;
        }
        
        return true;
    }
}


/*
- 진수 변환 함수 Convert
변환한 값을 int 형으로 반환

0으로 이루어지는 조건은 사실상 0으로 잘라서 보라는 배려와 같다고 봄
*/