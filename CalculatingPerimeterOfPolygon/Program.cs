using HomeWork_6;

try
{
    for (int i = 3; i <= 5; i++)
    {
        Point[] points = Point.GetArrayOfPoints(i);

        Polygon polygon = new Polygon(points);

        double perimeter = polygon.Perimeter();

        Console.WriteLine($"Колличество сторон многоугольника равно: {i}");
        Console.WriteLine();

        foreach (Point point in points)
        {
            Console.WriteLine(point.ToString());
        }

        Console.WriteLine($"Периметер многоугольника равен: {perimeter}");
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine("В работе программы произошла ошибка!");
    Console.WriteLine(ex.ToString());
}
