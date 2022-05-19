namespace OnceLeetCodePerDay.Implements;

public class L206ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        if(head == null || head.next == null)
        {
            return head;
        }

        var last = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return last;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}