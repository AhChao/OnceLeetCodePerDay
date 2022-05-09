namespace OnceLeetCodePerDay.Implements;

public class L1342NumberOfStepsToReduceANumberToZero
{
    public int NumberOfSteps(int num)
    {
        var times = 0;
        while(num != 0)
        {
            num = num % 2 == 0 ? num / 2 : num - 1;
            times++;
        }

        return times;
    }
}