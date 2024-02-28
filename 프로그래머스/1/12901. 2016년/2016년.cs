public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        int num = 0;
        
        int[] month = new int[] {31,29,31,30,31,30,31,31,30,31,30,31};
        string[] day = new string[] {"FRI","SAT","SUN","MON","TUE","WED","THU"};
        
        for(int i = 0; i < a-1; ++i)
        {
            num += month[i];
        }
        
        num += b;
        num %= 7;
        
        return num == 0 ? day[6] : day[num -1];
    }
}