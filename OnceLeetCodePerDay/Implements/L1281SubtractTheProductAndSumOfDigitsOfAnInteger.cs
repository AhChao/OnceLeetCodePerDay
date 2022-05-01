namespace OnceLeetCodePerDay.Implement;

public class L1281SubtractTheProductAndSumOfDigitsOfAnInteger
{
    public int SubtractProductAndSum(int n)
    {
        var product = n % 10;
        var sum = n % 10;
        n /= 10;
        while(n != 0)
        {
            product *= n % 10;
            sum += n % 10;
            n /= 10;
        }

        return product - sum;
    }
}