using System;
using System.Collections.Generic;


public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> playerMap = new Dictionary<string, int>();
        for(int i = 0; i < players.Length; ++i)
        {
            playerMap.Add(players[i], i);
        }       
                
        for(int i = 0; i < callings.Length; ++i)
        {
            int calledIndex = playerMap[callings[i]];
            string temp = players[calledIndex - 1];
            
            players[calledIndex - 1] = callings[i];
            players[calledIndex] = temp;
            
            playerMap[callings[i]] = calledIndex - 1;
            playerMap[temp] = calledIndex;
        }
        
        return players;
    }
    
}

/*
딕셔너리 선수 => [이름, 등수]

callings순회
{
calledIndex = 딕셔너리(callings[i]); 불린 애 자리
string temp = 플레이어 배열[calledIndex - 1]; 불린 애 선두 문자열

자리 바꾸기
플레이어 배열[calledIndex - 1] = callings[i];
플레이어 배열[calledIndex] = temp;

딕셔너리[callings[i]] = calledIndex - 1;
딕셔너리[temp] = calledIndex;
}
*/