namespace OpenClose
{
    class ColorAndSizeSpec : ISpecification<Product>
    {
        private readonly Color color;
        private readonly Size size;

        public ColorAndSizeSpec(Color color, Size size)
        {
            this.color = color;
            this.size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == this.color && t.Size == this.size;
        }
    }
}
