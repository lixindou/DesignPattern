using System.Collections.Generic;
using System.Linq;

namespace OpenClose
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec) => items.Where(p => spec.IsSatisfied(p));
    }
}
