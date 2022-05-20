using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1773CountItemsMatchingARule
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        //items[i] = [typei, colori, namei]
        return items.Count(x => (ruleKey == "type" && x[0] == ruleValue) || (ruleKey == "color" && x[1] == ruleValue) ||
                                (ruleKey == "name" && x[2] == ruleValue));
    }
}