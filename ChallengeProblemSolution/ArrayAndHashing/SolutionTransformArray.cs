namespace ChallengeProblemSolution.ArrayAndHashing;

public class SolutionTransformArray
{
    public int[] TransformArray(int[] nums)
    {
        int start = 0, 
            end = nums.Length - 1;

        var res = new int[nums.Length];

        foreach (var item in nums)
        {
            if (item % 2 == 0)
            {
                res[start] = 0;
                start++;
            }
           
            if(item % 2 == 1)
            {
                res[end] = 1;
                end--;
            }
        }

        return res;
    }
}