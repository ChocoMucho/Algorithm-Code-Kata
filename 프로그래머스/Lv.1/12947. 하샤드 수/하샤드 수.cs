public class Solution {
    public bool solution(int x) {
        int num = 0;
        int temp = x;
        string str = x.ToString();
        
        for(int i=0; i<str.Length; ++i)
        {
            num += temp%10;
            temp /= 10;
        }
        
        return x%num == 0 ? true : false;
    }
}