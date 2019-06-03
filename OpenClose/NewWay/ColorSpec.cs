namespace OpenClose
{
    public class ColorSpec : ISpecification<Product>
    {
        private Color color;

        public ColorSpec(Color color)
        {
            this.color = color;
        }
        public bool IsSatisfied(Product t)
        {
            return t.Color == this.color;
        }
    }
}