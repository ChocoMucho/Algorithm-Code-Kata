using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int storey) {
        int answer = 0;
        int idx = 10;
        Console.WriteLine("storey:"+storey);
        while(storey > 0) // 16
        {
            int nokori = storey % 10;  // 6 2
            if(nokori >= 5 && (storey / 10) % 10 >= 5)
            {
                storey += 10;
                answer += 10 - nokori;
            }
            else if(nokori >= 6)
            {
                storey += 10; // storey 20
                answer += 10 - nokori; //answer 4
            }
            else
                answer += nokori; // answer 6
            
            storey /= 10; // 2 0
        }
        Console.WriteLine("answer:"+answer);
        return answer;
    }
}

// BFS되지 않을까?