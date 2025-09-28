namespace ChallengeProblemSolution.Math;

public class SolutionMinimumSum
{
    public int MinimumSum(int num)
    {
        var digits = new int[4];
        for (int i = 0; i < 4; i++)
        {
            digits[i] = num % 10;
            num /= 10;
        }

        Array.Sort(digits);

        int x = digits[0] * 10 + digits[2];
        int y = digits[1] * 10 + digits[3];

        return x + y;
    }
}