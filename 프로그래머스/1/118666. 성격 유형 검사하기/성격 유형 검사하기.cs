using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        Dictionary<char, int>save = new Dictionary<char, int>();
        save.Add('R', 0);
        save.Add('T', 0);
        save.Add('C', 0);
        save.Add('F', 0);
        save.Add('J', 0);
        save.Add('M', 0);
        save.Add('A', 0);
        save.Add('N', 0);
        
        for(int i = 0; i < survey.Length; ++i)
        {
            if(choices[i] < 4)
                save[survey[i][0]] += 4 - choices[i];
            else if(choices[i] > 4)
                save[survey[i][1]] += choices[i] - 4;
        }
        
        answer += save['R'] >= save['T'] ? 'R' : 'T';
        answer += save['C'] >= save['F'] ? 'C' : 'F';
        answer += save['J'] >= save['M'] ? 'J' : 'M';
        answer += save['A'] >= save['N'] ? 'A' : 'N';
        
        return answer;
    }
}