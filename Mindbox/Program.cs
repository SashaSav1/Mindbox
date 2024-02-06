using ClassLibrary1;

// Круг
Circle Circle = new Circle(56);
try
{
    Console.WriteLine("Площадь круга: " + Circle.CalculateArea());
}
catch (ArgumentException ex)
{
    Console.WriteLine("Произошла ошибка: " + ex.Message);
}

// Треугольник
Triangle Triangle = new Triangle(10, 4, 5);
try
{
    Console.WriteLine("Площадь треугольника: " + Triangle.CalculateArea());
}
catch (ArgumentException ex)
{
    Console.WriteLine("Произошла ошибка: " + ex.Message);
}

if (Triangle.IsRectangularTriangle())
{
    Console.WriteLine("Треугольник прямоугольный");
}
else
{
    Console.WriteLine("Треугольник не прямоугольный");
}

Console.ReadLine();
