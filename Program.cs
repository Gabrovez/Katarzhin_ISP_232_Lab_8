using HtmlAgilityPack;
using MyApp.Models;
using MyClass;
using Newtonsoft.Json;
using static Katarzhin_ISP_232_Lab_8.SmartHome;
using MathLibrary;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLength("Пингвинчики");
            PrintLength(null);




        }
        static void PrintLength(string? input)
        {
            if (input != null)
            {
                Console.WriteLine($"Length of input: {input.Length}");
            }
            else
            {
                Console.WriteLine($"There is no line");
            }
        }
    }  

 }










//static void Main(string[] args)

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
