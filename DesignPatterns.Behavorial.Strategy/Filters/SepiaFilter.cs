namespace DesignPatterns.Behavioral.Strategy.Strategies
{
    public class SepiaFilter(double opacity) : IFilterStrategy
    {
        public void ApplyFilter(Image image)
        {
            // Apply sepia filter
        }
    }
}
