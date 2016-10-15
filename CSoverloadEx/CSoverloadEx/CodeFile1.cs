using System;

class Point
{
    //create a new point from x and y values
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    //crate a point from an existing point
    public Point(Point p)
    {
        this.x = p.x;
        this.y = p.y;
    }

    int x;
    int y;
}

class Test
{
    public static void Main()
    {
        Point myPoint = new Point(10, 15);
        Point mySecondPoint = new Point(myPoint);

        Console.WriteLine("myPoint({0}, {1})", myPoint);
        Console.WriteLine("mySecondPoint({0}, {1})", mySecondPoint);
    }
}