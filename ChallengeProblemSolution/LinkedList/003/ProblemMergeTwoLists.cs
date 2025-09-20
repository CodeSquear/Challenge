namespace ChallengeProblemSolution.LinkedList._003;

public class ProblemMergeTwoLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var list = GetListConverterFuncListNode(list1)
            .Concat(GetListConverterFuncListNode(list2));

        var orderBy = list.OrderBy(x => x).ToList();

        var dummy = new ListNode(0);
        var curr = dummy;

        foreach (var item in orderBy)
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy.next;
    }

    private List<int> GetListConverterFuncListNode(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while (curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        return list;
    }
}