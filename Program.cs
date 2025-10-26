using MyApp.Models;
using MyClass;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace Katarzhin_ISP_232_Lab_8
{// я не понял где первый комит потому что я же вроде его с этого проекта тоже отправил типо и класс у меня новый здесь есть using MyClass; тоже горит, ну ладно
    internal class Program{
        static void Main(string[] args){
            int? val = null;
            IsNull(val);
            val = 22;   
            IsNull(val);
            void IsNull(int? obj)
            {
                if (obj == null) Console.WriteLine("null");
                else Console.WriteLine(obj);
            }
            Console.WriteLine(val);



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
