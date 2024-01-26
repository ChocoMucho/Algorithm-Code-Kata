public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        
        answer[0] = GCD(m,n);
        answer[1] = (n*m) / answer[0];
        
        return answer;
    }
    
    public int GCD(int m, int n)
    {        
        if(n == 0) // 베이스 케이스
            return m;
        
        return GCD(n, m%n);
    }
}