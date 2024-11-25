namespace ConsoleApp.ClassesDemo
{
    public class Cuboid : Polygon, I2DShape, I3DShape
    {
        public override double Area()
        {
            return 2 * (Width * Length) + (Height * Length) 
        }

        public double Perimeter()
        {
            throw new NotImplementedException();
        }

        public double volume()
        {
            throw new NotImplementedException();
        }
    }
}