using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        report = report.Distinct().ToArray();
        Dictionary<string, List<string>> userDict = new Dictionary<string, List<string>>();
        
        for(int i = 0; i < id_list.Length; ++i)
            userDict.Add(id_list[i],new List<string>());
        
        for(int i = 0; i < report.Length; ++i)
        {
            string[] temp = report[i].Split(' '); // 0:신고자 1:피신고자
            
            userDict[temp[1]].Add(temp[0]);
        }
        
        for(int i = 0; i < id_list.Length; ++i)
        {
            foreach(KeyValuePair<string, List<string>> item in userDict)
            {
                if(item.Value.Count >= k && item.Value.Contains(id_list[i]))
                    ++answer[i];
            }
        }
        
        return answer;
    }
}

/*
동일한 유저 여러번 신고 == 1회
k번 이상 신고당함 => 정지
그 유저 신고한 유저들에게 정지 사실 전송

===초기화===
1. report 중복 요소 제거 -> 동일 유저 신고 중복 제거
2. 유저들 딕셔너리 키:이름 / 값: 신고한 유저 List => userDict
3. userDict 초기화
===report 순회===
4. 요소마다 신고자 피신고자 구분
5. userDIct의 피신고자를 키로 신고자를 값의 List에 추가
===정지 알림 횟수 정리===
6. id_list만큼 돌기
7. 딕셔너리 페어로 순회 -> 리스트에서 피신고자 수 체크 && 신고자 이름 포함됐는지 확인

결과물. 유저별로 자기가 신고한 유저들 중 정지 된 유저 수 
*/