using System;

public class Solution {
    public int[] answer = new int[2];
    
    public int[] solution(int[,] arr) {        
        Quad(arr, 0, 0, arr.GetLength(0));        
        return answer;
    }
    
    public void Quad(int[,] arr, int x, int y, int length){
        if(length <= 1) // 베이스 케이스
        {
            ++answer[arr[x,y]];
            return;
        }
        
        bool onlyZero = true;
        bool onlyOne = true;
        
        for(int i = x; i < x + length; ++i)
        {
            for(int j = y; j < y + length; ++j)
            {
                if(arr[i,j] == 0)
                    onlyOne = false;
                if(arr[i,j] == 1)
                    onlyZero = false;
            }
        }
        
        if(onlyZero)
        {
            ++answer[0];
            return;
        }
        if(onlyOne)
        {
            ++answer[1];
            return;
        }
        
        Quad(arr, x, y, length/2); //좌상
        Quad(arr, x, y+length/2, length/2); //우상
        Quad(arr, x+length/2, y, length/2); //좌하
        Quad(arr, x+length/2, y+length/2, length/2); //우하
    }
}

/*

*/