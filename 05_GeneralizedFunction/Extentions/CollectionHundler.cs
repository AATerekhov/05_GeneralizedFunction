using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GeneralizedFunction.Extentions
{
    public static class CollectionHundler
    {
        public static TElement? GetMax<TElement>(this IEnumerable<TElement> collection, Func<TElement, float> comparison)
            where TElement : class
        {
            return collection.OrderByDescending(comparison.Invoke).FirstOrDefault();
        }
    }
}
