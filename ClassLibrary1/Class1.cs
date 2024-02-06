namespace ClassLibrary1
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным");

            double S = Math.PI * radius * radius;

            return S;
        }
    }

    public class Triangle : IShape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Длины сторон должны быть положительными");

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                throw new ArgumentException("Треугольник с такими сторонами не может существовать");

            double p = (side1 + side2 + side3) / 2;
            double S = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

            return S;
        }
        public bool IsRectangularTriangle()
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);

            if(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}