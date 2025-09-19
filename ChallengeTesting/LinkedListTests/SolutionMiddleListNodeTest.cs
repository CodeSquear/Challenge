using ChallengeProblemSolution.LinkedList._002;
using ChallengeTesting.LinkedListTests.Helper;

namespace ChallengeTesting.LinkedListTests;

public class SolutionMiddleListNodeTest
{
    private readonly SolutionMiddleNode _solution = new SolutionMiddleNode();

    [Fact]
    public void MiddleListNode_Returns_CaseOne()
    {
        var listNode =
            MiddleListNodeConvertListOutListNode
                .OutList(new List<int>() { 1, 2, 3, 4, 5 });
    }
}