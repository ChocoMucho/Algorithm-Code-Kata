using System;

public class Solution {
    public int solution(int age) {
        if(0>=age && age > 120)
            return 0;
        return 2023 - age;
    }
}