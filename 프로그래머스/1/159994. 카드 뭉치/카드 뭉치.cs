using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int cards1Index = 0;
        int cards2Index = 0;
        int goalLength = goal.Length;
        
        for(int i = 0; i < goalLength; ++i)
        {
            if(cards1Index < cards1.Length && goal[i] == cards1[cards1Index])
            {
                ++cards1Index;
                continue;
            }
            else if(cards2Index < cards2.Length && goal[i] == cards2[cards2Index])
            {
                ++cards2Index;
                continue;
            }
            else
            {
                return "No";
            }
        }
        
        return "Yes";
    }
}