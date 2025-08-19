using System;
using System.Collections.Generic;

public class Solution { // 가중치 배열 [781, 156, 31, 6, 1]
    public int solution(string word) {
        int answer = 0;
        int[] weights = new int[]{781, 156, 31, 6, 1};
        Dictionary<char, int> wordMap = new Dictionary<char, int>
        {
            {'A',0},
            {'E',1},
            {'I',2},
            {'O',3},
            {'U',4}
        };
        int length = word.Length;
        
        // 자릿수*가중치+1
        for(int i = 0; i < length; ++i)
        {
            char c = word[i];
            answer += wordMap[c]*weights[i]+1;
        }
        
        return answer;
    }
}

/*
A E I O U => 0 1 2 3 4
각 자리에서 특정 값이 되게하는 수식이 필요
A는 어느 자리에서건 1이 된다는 전제
1 => A
2 => AA
3 => AAA

4 => AAAA
5 => AAAAA
6 => AAAAE E는 2가 됨, 5번째 자리의 E => 1*1+1
9 => AAAAU U는 5가 됨, U => 1*4+1
5번째자리 가중치 => 1

10 => AAAE E가 7이 됨, 4번째 자리의 E => ?*1+1 ?=>6
4번째 자리 가중치 => 6
11 => AAAEA 
12 => AAAEE
15 => AAAEU

AAAUU => 1+1+1+(6*4+1)+(1*4+1) => 33
AAE => 34 => 1+1+32
32 = ?*1+1
3번째 자리의 가중치 => 31

AAUUU => 1+1+(31*4+1)+25+5 => 157
AE => 158 // 두번째 자리의 E는 157
2번째 자리의 가중치 => 156

AUUUU => 1+(156*4+1)+125+25+5 => 781
E => 782
첫 번째 자리 가중치 => 781

가중치 배열 [781, 156, 31, 6, 1]
*/