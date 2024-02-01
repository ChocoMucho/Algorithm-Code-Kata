using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        
        int width = 0;
        int height = 0;
        
        for(int i = 0; i < sizes.GetLength(0); ++i)
        {
            int temp = 0;
            if(sizes[i,0] < sizes[i,1])
            {
                temp = sizes[i,0];
                sizes[i,0] = sizes[i,1];
                sizes[i,1] = temp;
            }
            
            if(width <= sizes[i,0])
                width = sizes[i,0];
            if(height <= sizes[i,1])
                height = sizes[i,1];
        }
        
        answer = width * height;
        
        return answer;
    }
}