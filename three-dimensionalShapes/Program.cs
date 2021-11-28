// See https://aka.ms/new-console-template for more information

using three_dimensionalShapes;

try
{
    Box box1 = new Box(20, "Базовый куб");


    Ball ball = new Ball(3, "Шар");

    if (box1.Add(ball) == true)
    {
        Console.WriteLine($"В фигуру \"{box1.Name}\" добавлена фигура: \"{ball.Name}\" объемом: {Math.Round(ball.Volume(), 3)} м3");
        Console.WriteLine($"Осталось: {Math.Round(box1.GetFreeSpace(), 3)} м3 из {Math.Round(box1.GetFreeSpace(), 3)} м3");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"Для добавления фигуры {ball.Name} не хватает места");
        Console.WriteLine();
    }

    box1.PrintFigures();

    Pyramid pyramid1 = new Pyramid(5, 1, "Пирамида 1");
    if (box1.Add(pyramid1) == true)
    {
        Console.WriteLine($"В фигуру \"{box1.Name}\" добавлена фигура: \"{pyramid1.Name}\" объемом: {Math.Round(pyramid1.Volume(), 3)} м3");
        Console.WriteLine($"Осталось: {Math.Round(box1.GetFreeSpace(), 3)} м3 из {Math.Round(box1.GetFreeSpace(), 3)} м3");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"Для добавления фигуры {pyramid1.Name} не хватает места");
        Console.WriteLine();
    }

    box1.PrintFigures();

    Pyramid pyramid2 = new Pyramid(4, 3, "Пирамида 2");
    if (box1.Add(pyramid2) == true)
    {
        Console.WriteLine($"В фигуру \"{box1.Name}\" добавлена фигура: \"{pyramid2.Name}\" объемом: {Math.Round(pyramid2.Volume(), 3)} м3");
        Console.WriteLine($"Осталось: {Math.Round(box1.GetFreeSpace(), 3)} м3 из {Math.Round(box1.GetFreeSpace(), 3)} м3");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"Для добавления фигуры {pyramid2.Name} не хватает места");
        Console.WriteLine();
    }

    box1.PrintFigures();

    Cylinder cylinder1 = new Cylinder(2, 8, "Малый целиндр");
    if (box1.Add(cylinder1) == true)
    {
        Console.WriteLine($"В фигуру \"{box1.Name}\" добавлена фигура: \"{cylinder1.Name}\" объемом: {Math.Round(cylinder1.Volume(), 3)} м3");
        Console.WriteLine($"Осталось: {Math.Round(box1.GetFreeSpace(), 3)} м3 из {Math.Round(box1.GetFreeSpace(), 3)} м3");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"Для добавления фигуры {cylinder1.Name} не хватает места");
        Console.WriteLine();
    }


    box1.PrintFigures();

    Cylinder cylinder2 = new Cylinder(10, 20, "Малый целиндр");
}
catch (Exception ex)
{
    Console.WriteLine("В работе программы произошла ошибка!");
    Console.WriteLine(ex.ToString());
}


