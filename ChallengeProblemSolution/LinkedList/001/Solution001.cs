namespace ChallengeProblemSolution.LinkedList._001;

public class Solution001
{
    public ListNode ReverseList(ListNode head)
    {
        var dummy = new ListNode(0);
        var curr = dummy;

        foreach (var item in GetList(head))
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy.next;
    }

    private List<int> GetList(ListNode head)
    {
        var curr = head;
        var list = new List<int>();

        while (curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        list.Reverse();

        return list;
    }
}