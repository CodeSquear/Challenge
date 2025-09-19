namespace ChallengeProblemSolution.LinkedList._002;

public class SolutionMiddleNode
{
    public ListNode MiddleNode(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while (curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        var dummy = new ListNode(0);
        curr = dummy;

        for (int i = list.Count / 2; i < list.Count; i++)
        {
            curr.next = new ListNode(list[i]);
            curr = curr.next;
        }

        return dummy.next;
    }
}