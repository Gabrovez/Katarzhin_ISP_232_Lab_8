using MyApp.Models;
using MyClass;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program{
        static void Main(string[] args){
            Player player = new Player();
            player.OnDeath += () => Console.WriteLine("Enemies celebrating their victory");
            player.OnDeath += ShowGO;
            player.TakeDamage(100);
        }
        static void ShowGO() => Console.WriteLine("GAME OVER");
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
