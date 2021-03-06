﻿namespace OpenClose
{
    public class SizeSpec : ISpecification<Product>
    {
        private readonly Size size;

        public SizeSpec(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == this.size;
        }
    }
}