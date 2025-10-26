using MyApp.Models;
using MyClass;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace Katarzhin_ISP_232_Lab_8
{// я не понял где первый комит потому что я же вроде его с этого проекта тоже отправил типо и класс у меня новый здесь есть using MyClass; тоже горит, ну ладно
    internal class Program{
        static void Main(string[] args){
            string? text = null;
            Console.WriteLine(text?.Length);
            string? name = null;
            string result = name ?? "Default";
            #nullable enable
            string? name_ = null;
            Console.WriteLine(name_!.Length);
            #nullable disable
            string hero = null;



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
