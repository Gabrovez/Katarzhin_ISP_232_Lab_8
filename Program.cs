using MyApp.Models;
namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {// Я принял позиция как нижний левый угол ибо если верхний будет 10 то тогда приведённые проверки не сходятся типо( 5 меньше 10 и они будет входить,
         // а 25 наоборот не будет)
            Point pos = new Point(10, 10);
            Point pon1 = new Point(15, 15);
            Point pon2 = new Point(5, 5);
            Point pon3 = new Point(25, 20);
            Rectangle rec = new Rectangle();
            rec.Width = 20;
            rec.Height = 15;
            rec.Position = pos;
            rec.Prinf();
            Console.WriteLine($"Плошадь: {rec.CalculateArea()}");
            Console.WriteLine($"Периметр: {rec.CalculatePerimeter()}");
            Console.WriteLine();
            rec.ContainsPoint(pon1);
            rec.ContainsPoint(pon2);
            rec.ContainsPoint(pon3);

        }
        public struct Rectangle
        {
            public int Width;
            public int Height;
            public Point Position;
            public void Prinf()
            {
                Console.WriteLine($"Прямоугольник: позиция ({Position.X}, {Position.Y}), ширина {Width}, высота {Height}");
            }
            public int CalculateArea()
            {
                return Width * Height;
            }
            public int CalculatePerimeter()
            {
                return 2 * (Width + Height);
            }
            public void ContainsPoint(Point point)
            {
                bool isin = point.X >= Position.X && point.X <= (Position.X + Width) && point.Y >= Position.Y && point.Y <= Position.Y + Height;
                Console.WriteLine($"Точка ({point.X},{point.X}) внутри прямоугольника: {isin}");
            }

        }
        public struct Point
        {
            public int X;
            public int Y;
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
 }
namespace Base
{
    class Company
    {
        string title;
        public Company(string title) => this.title = title;
        public void print() => Console.WriteLine($"Компания: {title}");
        public struct Point2D
        {
            public int X;
            public int Y;
            public Point2D(int x, int y)
            {
                X = x;
                Y = y;
            }
            public double Distanceto(Point2D other)
            {
                int dx = X - other.X;
                int dy = Y - other.Y;

                return Math.Sqrt(dx * dx + dy * dy);
            }

        }
    }
}
