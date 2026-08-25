using ChallengeProblemSolution.ArrayAndHashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTesting.StringTest;

public class MarjorityElementLabaratory
{
    private readonly SolutionMajorityElement _solution
        = new SolutionMajorityElement();

    [Fact]
    public int MajorityElement_Returns_CaseOne()
    {
        var nums = new int[] { 3, 2, 3 };
        var res = _solution.MajorityElements(nums);
        var exp = 3;
        Assert.Equal(exp, res);
        return res;
    }
}
