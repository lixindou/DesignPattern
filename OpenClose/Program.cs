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
            var greenProducts = oldFilter.FilterByColor(products, Color.Green).Select(p => p.Name);
            foreach (var name in greenProducts)
            {
                Console.WriteLine($"Green product: {name}");
            }
            var bigProducts = oldFilter.FilterBySize(products, Size.Big).Select(p => p.Name);
            foreach (var name in bigProducts)
            {
                Console.WriteLine($"Big product: {name}");
            }

            // new way
            var newFilter = new BetterFilter();
            greenProducts = newFilter.Filter(products, new ColorSpec(Color.Green)).Select(p => p.Name);
            foreach (var name in greenProducts)
            {
                Console.WriteLine($"Green product: {name}");
            }
            bigProducts = newFilter.Filter(products, new SizeSpec(Size.Big)).Select(p => p.Name);
            foreach (var name in bigProducts)
            {
                Console.WriteLine($"Big product: {name}");
            }
            var greenAndBigProducts = newFilter.Filter(products, new ColorAndSizeSpec(Color.Green, Size.Big)).Select(p => p.Name);
            foreach (var name in greenAndBigProducts)
            {
                Console.WriteLine($"Big and Green product: {name}");
            }
            Console.ReadLine();
        }
    }
}
