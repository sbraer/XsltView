using System.Collections.Generic;
using System.Linq;

namespace XsltUtilities.Classes
{
    internal class MySortedDictionary : SortedDictionary<string, string>
    {
        internal int? HashKeyAttributesKeysAndValues { get; set; }
        internal new void Add(string key, string value)
        {
            base.Add(key, value);
            HashKeyAttributesKeysAndValues = this.Select(t => $"§{t.Key}§{t.Value}§").Aggregate((t, y) => t + y).ToString().GetHashCode();
        }
    }
}
