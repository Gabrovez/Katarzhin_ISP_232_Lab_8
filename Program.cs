using MyApp.Models;
namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueChecker vc = new ValueChecker();
            vc.CheckType(5);
            vc.CheckType("Hello");
            vc.CheckType(3.14);
            vc.CheckType(3.14f);
            vc.CheckType(true);
            vc.CheckType(123.4m);
            vc.CheckType(new object());
            vc.CheckType('A');






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
