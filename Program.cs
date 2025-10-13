namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Dodge";
            car1.Model = "Challenger";
            car1.Year = 2009;
            car1.Mileage = 300;
            car1.PrintInfo();
            Car car2 = new Car();
            car2.Brand = "Porche";
            car2.Model = "911 GTR 3s";
            car2.Year = 2015;
            car2.Mileage = 500;
            car2.PrintInfo();


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
