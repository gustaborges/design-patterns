using DesignPatterns.Behavioral.Strategy.Compressions;
using DesignPatterns.Behavioral.Strategy.Filters;
using DesignPatterns.Behavioral.Strategy.Strategies;

namespace DesignPatterns.Behavioral.Strategy
{
    public class ImageProcessor()
    {
        private IFilterStrategy _filterStrategy = new NoFilter();
        private ICompressionStrategy _compressionStrategy = new NoCompression();

        public void SetFilterStrategy(IFilterStrategy filterStrategy)
        {
            _filterStrategy = filterStrategy;
        }

        public void SetCompressionStrategy(ICompressionStrategy compressionStrategy)
        {
            _compressionStrategy = compressionStrategy;
        }

        public void Process(Image image)
        {
            _compressionStrategy.ApplyCompression(image);
            _filterStrategy.ApplyFilter(image);
        }
    }

}
