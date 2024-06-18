using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] nowPosition = new int[] {0,0};
        
        for(int i = 0; i < park.Length; ++i) // 시작 지점 탐지
        {
            for(int j = 0; j < park[i].Length; ++j)
            {
                if(park[i][j] == 'S')
                {
                    nowPosition[0] = i; // 0이 y
                    nowPosition[1] = j; // 1이 x
                    break;
                }
            }
        }
        
        for(int i = 0; i < routes.Length; ++i)
        {
            string[] temp = routes[i].Split(' ');
            string direction = temp[0];
            int distance = int.Parse(temp[1]);
            
            bool passed = true;
            
            for(int j = 1; j <= distance; ++j)
            {
                if(direction == "N")
                {
                    if(!CheckPath(park, nowPosition, -j, 0))
                    {
                        passed = false;
                        break;
                    }
                        
                }
                else if(direction == "S")
                {
                    if(!CheckPath(park, nowPosition, j, 0))
                    {
                        passed = false;
                        break;
                    }
                }
                else if(direction == "W")
                {
                    if(!CheckPath(park, nowPosition, 0, -j))
                    {
                        passed = false;
                        break;
                    }
                }
                else if(direction == "E")
                {
                    if(!CheckPath(park, nowPosition, 0, j))
                    {
                        passed = false;
                        break;
                    }
                }
            }
            
            if(passed)
            {
                if(direction == "N")
                    nowPosition[0] -= distance;
                else if(direction == "S")
                    nowPosition[0] += distance;
                else if(direction == "W")
                    nowPosition[1] -= distance;
                else if(direction == "E")
                    nowPosition[1] += distance;
                    
            }
                
        }
        
        return nowPosition;
    }
    
    public bool CheckPath(string[] park, int[] nowPosition, int y, int x)
    {
        int calX = nowPosition[1] + x;
        int calY = nowPosition[0] + y;
        
        //범위 넘는지 체크
        if(calX < 0 || calX >= park[0].Length)
            return false;
        if(calY < 0 || calY >= park.Length)
            return false;
        
        //못 가는 길 체크
        if(park[calY][calX] == 'X')
            return false;
        
        return true;
    }
}