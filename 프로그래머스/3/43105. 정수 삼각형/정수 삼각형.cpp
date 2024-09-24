#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(vector<vector<int>> triangle) {
    int answer = 0;    
    int length = triangle.size();
    
    for(int i = length-2; i >= 0; --i)
    {
        for(int j = 0; j < triangle[i].size(); ++j)
        {
            triangle[i][j] += std::max(triangle[i+1][j], triangle[i+1][j+1]);
        }
    }
    
    answer = triangle[0][0];
    
    return answer;
}
/*
아래에서 위로 올라가는 방식으로
5줄인 경우
4째 줄의 것들에 더 큰 값이 될 수 있는 것을 더해준다.
2=>(4,5) 7=>(5,2) 4=>(2,6) 4=>(6,5)
4째줄 => 7 12 10 10

3째 줄도 동일하게
8=>(7,12) 1=>(12, 10) 0=>(10, 10)
3째줄=> 20 13 10

2째줄
3=>(20, 13) 8=>(13, 10)
2째줄=>23 21

1째줄
7=>(23, 21)
1째줄 30
*/