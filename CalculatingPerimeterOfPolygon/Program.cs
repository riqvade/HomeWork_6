using HomeWork_6;

try
{
    for (int i = 3; i <= 5; i++)
    {
        Point[] points = Point.GetArrayOfPoints(i);

        Console.WriteLine($"Колличество сторон многоугольника равно: {i}");
        Console.WriteLine();

        foreach (Point point in points)
        {
            Console.WriteLine(point.ToString());
        }

        Polygon polygon = new Polygon(points);
        
        Console.WriteLine($"Периметер фигуры \"{polygon.Name}\" равен: {polygon.Perimeter()}");
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine("В работе программы произошла ошибка!");
    Console.WriteLine(ex.ToString());
}
