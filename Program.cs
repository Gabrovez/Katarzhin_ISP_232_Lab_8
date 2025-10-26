using MyApp.Models;
using MyClass;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace Katarzhin_ISP_232_Lab_8
{
    public delegate void NumberHandler(int number);
    internal class Program{
        static void Double(int num) => Console.WriteLine($"Doubled: {num * 2}");
        static void Square(int num) => Console.WriteLine($"Squared: {num * num}");
        static void Main(string[] args){

            NumberHandler handler = Double;
            handler += Square;
            handler(5);
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
