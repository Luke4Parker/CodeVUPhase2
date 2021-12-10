namespace SelfAssessment12
{
    public abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Shape(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public abstract double CalculateSurface();
           
    }
}
