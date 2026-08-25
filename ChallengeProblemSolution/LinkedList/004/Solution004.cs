namespace ChallengeProblemSolution.LinkedList._004;

public class Solution
{
    public void ReorderList(ListNode head)
    {
        var list = ListNodeConverterFunc(head);
        var res = MaxMinValue(list);

        var curr = head;
        
        foreach(var item in res)
        {
            curr.val = item;
            curr = curr.next;
        }
    }

    public List<int> ListNodeConverterFunc(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while(curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        return list;
    }

    public List<int> ReverseList(List<int> list)
    {
        list.Reverse();
        return list;
    }

    public int[] MaxMinValue(List<int> list)
    {
        int max = 0, min = 0;
        var arr = new int[list.Count];
        var reverse = ReverseList(list);

        for(int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                arr[i] = list[min];
                min++;
            }
            else
            {
                arr[i] = reverse[max];
                max++;
            }
        }
        return arr;
    }
}
