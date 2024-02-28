using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] answers)
    {
        List<int> answer = new List<int>();

        int[] student1 = new int[] { 1, 2, 3, 4, 5 };
        int[] student2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] student3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[] score = new int[] { 0, 0, 0 };

        for (int answer_i = 0; answer_i < answers.Length; ++answer_i)
        {
            if (answers[answer_i] == student1[answer_i % student1.Length])
                ++score[0];

            if (answers[answer_i] == student2[answer_i % student2.Length])
                ++score[1];

            if (answers[answer_i] == student3[answer_i % student3.Length])
                ++score[2];
        }

        for (int score_i = 0; score_i < score.Length; ++score_i)
        {
            if (score[score_i] == score.Max())
                answer.Add(score_i + 1);
        }


        return answer.ToArray();
    }
}