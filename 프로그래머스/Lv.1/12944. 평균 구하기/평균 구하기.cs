public class Solution {
    public double solution(int[] arr) {
        
        double result = 0;
        
        for(int i = 0; i < arr.Length; ++i)
        {
            result += arr[i];
        }
        
        return result / arr.Length;
    }
}