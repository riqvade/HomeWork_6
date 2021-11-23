using HomeWork_6;

try
{
    Point[] points = Point.GetArrayOfPoints(3);
    Console.WriteLine($"Колличество сторон многоугольника равно: {3}");
    Console.WriteLine();
    foreach (Point point in points)
    {
        Console.WriteLine(point.ToString());
    }
    Polygon polygon = new Polygon(points, $"Многоугольник 1");
    Console.WriteLine($"Периметер фигуры \"{polygon.Name}\" равен: {polygon.Perimeter()}");
    Console.WriteLine();


    points = Point.GetArrayOfPoints(4);
    Console.WriteLine($"Колличество сторон многоугольника равно: {4}");
    Console.WriteLine();
    foreach (Point point in points)
    {
        Console.WriteLine(point.ToString());
    }
    polygon = new Polygon(points, $"Многоугольник 2");
    Console.WriteLine($"Периметер фигуры \"{polygon.Name}\" равен: {polygon.Perimeter()}");
    Console.WriteLine();


    points = Point.GetArrayOfPoints(5);
    Console.WriteLine($"Колличество сторон многоугольника равно: {5}");
    Console.WriteLine();
    foreach (Point point in points)
    {
        Console.WriteLine(point.ToString());
    }
    polygon = new Polygon(points, $"Многоугольник 3");
    Console.WriteLine($"Периметер фигуры \"{polygon.Name}\" равен: {polygon.Perimeter()}");
    Console.WriteLine();
}
catch (Exception ex)
{
    Console.WriteLine("В работе программы произошла ошибка!");
    Console.WriteLine(ex.ToString());
}
