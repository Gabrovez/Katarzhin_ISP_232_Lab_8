using MyApp.Models;
using MyClass;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program{
        static void Main(string[] args){

            PrintNullable(5); 
            PrintNullable(null); 
            void PrintNullable(int? number)
            {
                if (number.HasValue)
                {
                    Console.WriteLine(number.Value);
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("параметр равен null");
                }
            }
            int? number = null;
            Console.WriteLine(number);
            Console.WriteLine(number.GetValueOrDefault());
            Console.WriteLine(number.GetValueOrDefault(10));
            number = 15;
            Console.WriteLine(number.GetValueOrDefault());
            Console.WriteLine(number.GetValueOrDefault(10));


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
