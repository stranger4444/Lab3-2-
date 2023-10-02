using ConsoleApp4;

class Program
{
    static void Main(string[] args)
    {
        Point[] points = new Point[]
        {
            new Point(5, 0, "A"),
            new Point(0, 4, "B"),
            new Point(4, 0, "C"),
            new Point(0, 5, "D"),
        };

        Figure figure = new Figure(points);
        figure.CalculatePerimeter();

        Console.ReadLine();
    }
}
