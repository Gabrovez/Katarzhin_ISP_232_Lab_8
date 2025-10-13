namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point2D(10, 20);
            var p2 = new Point2D(13, 24);
            Console.WriteLine($"Расстояние: {p1.Distanceto(p2):F2}");
        }
        public struct Point2D
        {
            public int X;
            public int Y;
            public  Point2D(int x, int y)
            {
                X = x;
                Y = y;
            }
            public double Distanceto(Point2D other)
            {
                int dx = X - other.X;
                int dy = Y - other.Y;

                return Math.Sqrt(dx * dx + dy* dy);
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
    }
}
