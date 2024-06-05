using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int> {};
        
        //1
        string format = "yyyy.MM.dd";
        DateTime datetimeToday = DateTime.ParseExact(today,format,null);             
        
        
        //2
        Dictionary<string, int> terms_data = new Dictionary<string, int>{};
        for(int i = 0; i < terms.Length; ++i)
        {
            string[] temrs_split = terms[i].Split(" ");
            terms_data.Add(temrs_split[0],int.Parse(temrs_split[1]));
        }
        
        
        //3
        for(int i=0; i<privacies.Length; ++i)
        {
            string[] privacy_split = privacies[i].Split(" ");

            DateTime datetimePrivacy = DateTime.ParseExact(privacy_split[0], format, null);
            int term = terms_data[privacy_split[1]];
            
            datetimePrivacy = datetimePrivacy.AddMonths(term);
            
            if(datetimeToday >= datetimePrivacy)
            {
                answer.Add(i+1);
            }            
        }
        
        answer.Sort();                   
                           
        return answer.ToArray();;
    }
}
