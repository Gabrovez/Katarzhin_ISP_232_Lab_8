using MyApp.Models;
using MyClass;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program{
        static void Main(string[] args){
           
            string? GetUserName(int id)
            {
                return id == 1 ? "Alice" : null;
            }
            var user = GetUserName(2);
            Console.WriteLine(user?.ToUpper());

            string? input = Console.ReadLine();
            if (input != null)
                Console.WriteLine($"You entered: {input}");
            else
                Console.WriteLine($"You haven't entered anything!");

            List<string?> names = new() { "Anna", null, "Bob" };
            foreach (var name in names)
            {
                Console.WriteLine(name?.Length ?? 0);
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
