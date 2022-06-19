using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1268SearchSuggestionsSystem
{
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        var result = new List<IList<string>>();
        var list = products.OrderBy(x => x).ToList();
        for(var i = 0; i < searchWord.Length; i++)
        {
            var searchString = searchWord.Substring(0, i + 1);
            list = list.Where(x => x.IndexOf(searchString) == 0).ToList();
            result.Add(list.Take(3).ToList());
        }

        return result;
    }
}