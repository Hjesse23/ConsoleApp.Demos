namespace ConsoleApp.ClassesDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public int Length { get; set; }
        public override double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}