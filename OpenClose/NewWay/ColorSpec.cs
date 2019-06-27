namespace OpenClose
{
    public class ColorSpec : ISpecification<Product>
    {
        private readonly Color color;

        public ColorSpec(Color color) => this.color = color;

        public bool IsSatisfied(Product t)
        {
            return t.Color == this.color;
        }
    }
}