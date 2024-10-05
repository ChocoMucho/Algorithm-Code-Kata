#include <string>
#include <vector>
#include <stack>

using namespace std;

bool CheckCorrect(string value);
string MakeValid(string value);
int FindBalanceIndex(string value);
string MainFunction(string value);

string solution(string p) {
    string answer = "";    
    if(CheckCorrect(p))
        return p;
    
    answer = MainFunction(p);
    
    return answer;
}

string MainFunction(string value)
{
    if(value.length() <= 0)
        return "";
    string u,v;
    int subIndex = FindBalanceIndex(value) + 1;
    u = value.substr(0,subIndex); //균형잡힌 괄호 부분
    v = value.substr(subIndex); //나머지 
    
    if(CheckCorrect(u)) //u가 올바른 문자열이면 
        u += MainFunction(v);
    else
    {
        string copy = "";
        string temp = "(";
        temp += MainFunction(v);
        temp += ")";
        if(u.length() >= 4)
        {
            copy = u.substr(1, u.length()-2);//앞뒤 잘라내기
            copy = MakeValid(copy);
        }
        temp += copy;
        u = temp;
    }
    return u;
}

int FindBalanceIndex(string value) //균형잡힌 괄호까지의 인덱스
{
    int length = value.length();
    int balance = value[0] == '(' ? -1 : 1;
    for(int i = 1; i < length; ++i)
    {
        balance += value[i] == '(' ? -1 : 1;
        if(balance == 0)
            return i;
    }
    return -1;
}

bool CheckCorrect(string value)//올바른 괄호 체크
{
    std::stack<char> stack;
    int length = value.length();
    
    for(int i = 0; i < length; ++i)
    {
        if(value[i] == '(')
        {
            stack.push(value[i]);
        }
        else if (value[i] == ')')
        {
            if(stack.empty())
                return false;
            stack.pop();
        }
    }
    
    return stack.empty();
}

string MakeValid(string value)
{
    int length = value.length();
    string validString = "";
    for(int i = 0; i < length; ++i)
    {
        validString += value[i] == '(' ? ')' : '('; 
    }
    
    return validString;
}

/*
1. u에다가 균형잡힌 문자열 대입
1-1. v에다가 나머지 문자열 대입
2. u가 올바른 문자열인지 확인
2-1. v가 길이가 0이면 그냥 u 반환
3. u가 올바른 문자열 아니면 u에 대해서 올바르게 고쳐주기
4. 끝났으면 v의 값으로 1부터 반복

- 균형잡힌 문자열 잘라내는 방법
- 올바른 문자열 인식하는 방법
*/