using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Contest._0501.Implement;

public class L6048MinimumConsecutiveCardsToPickUp
{
    public int MinimumCardPickup(int[] cards)
    {
        var valueMappingDictionary = new Dictionary<int, CustomizeNumber>();
        for(var i = 0; i < cards.Length; i++)
        {
            if(!valueMappingDictionary.ContainsKey(cards[i]))
            {
                valueMappingDictionary.Add(cards[i], new CustomizeNumber
                                                     {
                                                         LastPosition = i,
                                                         MinDistance = -1
                                                     });
            }
            else
            {
                var temp = valueMappingDictionary[cards[i]];
                if(temp.MinDistance == -1)
                {
                    temp.MinDistance = i - temp.LastPosition + 1;
                }
                else
                {
                    temp.MinDistance = temp.MinDistance > i - temp.LastPosition + 1
                                           ? i - temp.LastPosition + 1
                                           : temp.MinDistance;
                }

                temp.LastPosition = i;
            }
        }

        var resultCollection = valueMappingDictionary.Where(x => x.Value.MinDistance != -1);
        return resultCollection.Count() > 0 ? resultCollection.Min(x => x.Value.MinDistance) : -1;
    }
}

public class CustomizeNumber
{
    public int LastPosition { get; set; }
    public int MinDistance { get; set; }
}