using System;

namespace OnceLeetCodePerDay.Contest._0611.Implements;

public class L6096SuccessfulPairsOfSpellsAndPotions
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        var result = new int[spells.Length];
        Array.Sort(potions);
        for(var i = 0; i < spells.Length; i++)
        {
            result[i] = CustomizeBinarySearch(potions, 0, potions.Length,
                                              (long)Math.Ceiling(success / (decimal)spells[i]));
        }

        return result;
    }

    private int CustomizeBinarySearch(int[] potions, int leftIndex, int rightBound, long target)
    {
        while(leftIndex < rightBound)
        {
            var mid = (leftIndex + rightBound) / 2;
            if(potions[mid] >= target)
            {
                rightBound = mid;
            }
            else
            {
                leftIndex = mid + 1;
            }
        }

        return potions.Length - leftIndex;
    }
}