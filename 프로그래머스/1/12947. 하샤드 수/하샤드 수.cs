public class Solution {
    public bool solution(int n) {
        bool answer = true;
        int bucket = n;
        int temp = 0;
        
        while(n != 0)
        {
            temp += n % 10;
            n /= 10;
        }
        
        answer = bucket % temp == 0;
        
        return answer;
    }
}