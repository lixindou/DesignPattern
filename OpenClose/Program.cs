using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Product("Tree", Color.Green, Size.Big);
            var apple = new Product("Apple", Color.Green, Size.Small);
            var house = new Product("House", Color.Blue, Size.Big);
            var products = new List<Product>{tree, apple, house};

            // Old way
            var oldFilter = new Filter();
            var greenProduct = oldFilter.FilterByColor(products, Color.Green).Select(p => p.Name);
            foreach (var name in greenProduct)
            {
                Console.WriteLine($"Green product: {name}");
            }
            var bigProduct = oldFilter.FilterBySize(products, Size.Big).Select(p => p.Name);
            foreach (var name in bigProduct)
            {
                Console.WriteLine($"Big product: {name}");
            }

            // new way
            var newFilter = new BetterFilter();
            greenProduct = newFilter.Filter(products, new ColorSpec(Color.Green)).Select(p => p.Name);
            foreach (var name in greenProduct)
            {
                Console.WriteLine($"Green product: {name}");
            }
            bigProduct = newFilter.Filter(products, new SizeSpec(Size.Big)).Select(p => p.Name);
            foreach (var name in bigProduct)
            {
                Console.WriteLine($"Big product: {name}");
            }
            var greenAndBigProducts = newFilter.Filter(products, new ColorAndSizeSpec(Color.Green, Size.Big));
            Console.ReadLine();
        }
    }
}
