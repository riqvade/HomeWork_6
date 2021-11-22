// See https://aka.ms/new-console-template for more information

using three_dimensionalShapes;

try
{
    Box box1 = new Box(5.5, "Базовый куб");
    Box testBox = new Box(5.5, "Базовый куб");
    box1.Add(Ball.GetRandomBall());
    Box box2 = new Box(4);
    Cylinder smallCylinder = new Cylinder(2, 1, "Малый целиндр");
    box2.Add(smallCylinder);
    box1.Add(box2);

    box1.Add(Pyramid.GetRandomPyramid());
    box1.Add(new Pyramid(5, 7, "Пирамида Хеопса"));
    box1.Add(Pyramid.GetRandomPyramid());
    box1.Add(new Cylinder(2, 2, "Малый целиндр"));
    box1.Add(smallCylinder);
    box1.Add(new Cylinder(3, 2, "Большой целиндр"));

    box1.PrintFigures();
    box2.PrintFigures();
}
catch (Exception ex)
{
    Console.WriteLine("В работе программы произошла ошибка!");
    Console.WriteLine(ex.ToString());
}


