using ChallengeProblemSolution.LinkedList._001;

namespace ChallengeTesting.LinkedListTests.Helper;

public static class MiddleListNodeConvertListOutListNode
{
    public static ListNode OutList(List<int> list)
    {
        var listNode = new ListNode(0);
        var curr = listNode;

        foreach (var item in list)
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return listNode.next;
    }
}