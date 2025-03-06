#include <iostream>
#include <string>
#include <vector>
#include <map>

using namespace std;

vector<int> solution(vector<string> name, vector<int> yearning, vector<vector<string>> photo) {
    vector<int> answer;
    map<string, int> scoreMap;
    
    // 1. 이름이랑 점수 매핑
    for(int i = 0; i < name.size(); ++i)
    {
        scoreMap[name[i]] = yearning[i];
    }
    
    // 3. photo 순회하기
    for(int i = 0; i < photo.size(); ++i)
    {
        int temp = 0;
        for(int j = 0; j < photo[i].size(); ++j)
        {
            
            if(scoreMap.find(photo[i][j]) != scoreMap.end())
            {
                temp += scoreMap[photo[i][j]];
            }
        }
        answer.push_back(temp);
    }
    
    return answer;
}
/*C#이 아닌 경우임 -> C#의 컬렉션들을 대체할 것 생각
1. 이름과 점수를 매핑 -> 딕셔너리같은 해시테이블의 무언가 있나?
2. photo 행의 수만큼 answer 길이 정의해주기 -> vector라서 안해도 됨
3. photo의 행 순회하면서 내부의 것들 합해주기
@ 순회 할 때 없는 요소인지 확인 필요
*/