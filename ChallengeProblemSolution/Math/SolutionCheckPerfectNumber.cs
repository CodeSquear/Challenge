﻿namespace ChallengeProblemSolution.Math;

public class SolutionCheckPerfectNumber
{
    public bool CheckPerfectNumber(int num)
    {
        var sum = 0;
        for (int i = 1; i <= num / 2; i++)
            if (num % i == 0)
                sum += i;

        return sum == num;
    }
}