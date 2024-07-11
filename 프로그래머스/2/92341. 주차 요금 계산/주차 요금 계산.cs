using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] fees, string[] records) {
        List<int> answer = new List<int>();
        Dictionary<string, int> result = new Dictionary<string, int>(); //번호, 누적시간
        Dictionary<string, string> checkDic = new Dictionary<string, string>(); //번호, 시간
        
        foreach(string record in records)
        {
            //0:시각 1:차량 번호 2:내역
            string[] temp = record.Split(' ');
            
            if(!result.ContainsKey(temp[1]))
                    result.Add(temp[1], 0);
            
            if(temp[2] == "IN") // 입차
            {
                checkDic.Add(temp[1], temp[0]);
            }                
            else if(temp[2] == "OUT") // 출차
            {                
                // 시간 누적
                result[temp[1]] += TimeToMinutes(temp[0]) - TimeToMinutes(checkDic[temp[1]]);
                
                // checkDic에서 해당 요소 제거
                checkDic.Remove(temp[1]);
            }
        }
        
        // IN만 찍힌 차량들 시간 누적 처리
        foreach(KeyValuePair<string, string> item in checkDic)
        {
            result[item.Key] += TimeToMinutes("23:59") - TimeToMinutes(item.Value);
        }
        
        List<string> list = result.Keys.ToList();
        list.Sort();
        
        foreach(string item in list)
        {
            // 시간에 따른 요금 계산해서 리스트에 입력            
            answer.Add(CalculateFee(fees, result[item]));
        }
        
        return answer.ToArray();
    }
    
    public int CalculateFee(int[] fees, int accTime)
    {          
        if(fees[0] >= accTime)
            return fees[1];
        else
        {
            int finTime = accTime - fees[0];
            int fee = fees[3] * (int)Math.Ceiling((double)finTime / fees[2]);
            return fee + fees[1];
        }
    }
    
    public int TimeToMinutes(string time)
    {
        int[] timeArr = Array.ConvertAll(time.Split(':'), s => int.Parse(s));
        
        return (timeArr[0] * 60) + timeArr[1];
    }
}