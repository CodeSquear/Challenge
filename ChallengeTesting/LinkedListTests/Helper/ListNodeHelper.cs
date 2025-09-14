using ChallengeProblemSolution.LinkedList._001;

namespace ChallengeTesting.LinkedListTests.Helper;

public static class ListNodeHelper
{
    public static ListNode FromList(List<int> values)
    {
        if (values == null || values.Count == 0) return null;

        var dummy = new ListNode(0);
        var current = dummy;
        foreach (var val in values)
        {
            current.next = new ListNode(val);
            current = current.next;
        }

        return dummy.next;
    }
    public static List<int> ToList(ListNode head)
    {
        var result = new List<int>();
        var current = head;
        while (current != null)
        {
            result.Add(current.val);
            current = current.next;
        }
        return result;
    }
}