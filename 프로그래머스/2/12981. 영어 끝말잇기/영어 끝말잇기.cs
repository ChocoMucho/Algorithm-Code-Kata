using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];
        int length = words.Length;
        Dictionary<string, bool> wordCheck = new Dictionary<string, bool>();

        wordCheck.Add(words[0], true); // true는 한 번만 언급됐다는 뜻
        char temp = words[0][words[0].Length - 1];
        
        for(int i = 1; i < length; ++i)
        {
            if(temp != words[i][0] || wordCheck.ContainsKey(words[i]))
            {
                answer[0] = (i % n) + 1;
                answer[1] = (i / n) + 1;
                break;
            }
            
            wordCheck.Add(words[i], true);
            temp = words[i][words[i].Length - 1];
        }
        
        return answer;
    }
}

/*
- 딕셔너리로 단어 체크하기. <string, bool>
- words 전체 순회, 0번째는 끝 글자 저장하고 딕셔너리에 넣어놓기
    - 1번째부터 이어지는지 체크
    - 딕셔너리에 있는 단어인지 체크
    - 다 통과되면 딕셔너리에 넣기
- words 순회에서 통과 못 한 경우
    - 몇 번째 사람인지 | (i % n) + 1-> (7%5)+1 = 3
    - 몇 번째 차례에 틀린건지 | (i/n)+1 -> (7/5) + 1 = 2
*/