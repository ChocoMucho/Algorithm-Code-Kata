using System;

class Solution 
{
    public int solution(int n) 
   {
        int answer = 0;
        
        int smallest1 = n & -n;
        int ripple = n + smallest1;
        int newBit = n ^ ripple;
        
        int changed = newBit / smallest1;
        int shiftRight = changed >> 2;
        
        answer = ripple | shiftRight;

        return answer;
    }
}