namespace OnceLeetCodePerDay.Implements;

public class L83RemoveDuplicatesFromSortedList
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if(head == null)
        {
            return null;
        }

        var dummy = new ListNode(-1, head);
        var slow = head;
        while(head != null)
        {
            if(slow.val != head.val)
            {
                slow = slow.next;
                slow.val = head.val;
            }

            head = head.next;
        }

        slow.next = null;
        return dummy.next;
    }
}