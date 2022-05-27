namespace OnceLeetCodePerDay.Implements;

public class L1290ConvertBinaryNumberInALinkedListToInteger
{
    public int GetDecimalValue(ListNode head)
    {
        var result = 0;
        while(head != null)
        {
            result *= 2;
            result += head.val;
            head = head.next;
        }

        return result;
    }
}