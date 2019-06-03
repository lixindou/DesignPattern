using System.Collections.Generic;
using System.Linq;

namespace OpenClose
{
    public class Filter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> t, Color color)
        {
            return t.Where(p => p.Color == color);
        }

        public IEnumerable<Product> FilterBySize(IEnumerable<Product> t, Size size)
        {
            return t.Where(p => p.Size == size);
        }

        //public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> t, Color color, Size size)
        //{
        //    return t.Where(p => p.Color == color && p.Size == size);
        //}
    }
}
