namespace OnceLeetCodePerDay.Implements;

public class L1672RichestCustomerWealth
{
    public int MaximumWealth(int[][] accounts)
    {
        var maxAmount = 0;
        foreach(var i in accounts)
        {
            var totalAmount = 0;
            foreach(var amount in i)
            {
                totalAmount += amount;
            }

            if(maxAmount < totalAmount) maxAmount = totalAmount;
        }

        return maxAmount;
    }
}