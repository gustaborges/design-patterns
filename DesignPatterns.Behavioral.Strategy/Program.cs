
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Strategy.Compressions;
using DesignPatterns.Behavioral.Strategy.Strategies;

// Strategy Design Pattern
// Keypoint: Switching algorithms at runtime

var imageProcessor = new ImageProcessor();

imageProcessor.SetFilterStrategy(new SepiaFilter(0.2));
imageProcessor.SetCompressionStrategy(new PngCompression());

var image = new Image();
imageProcessor.Process(image);