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
    internal class Program{
        static void Main(string[] args)
        {
            Thermometer th = new Thermometer();

            th.TemperatureTooHigh += OnTemperatureTooHigh;

            th.Measure(15);
            th.Measure(150);




        }
        public static void OnTemperatureTooHigh(string mes)
        {
            Console.WriteLine(mes);
        }
    }    
    public class Thermometer
    {
        public event Action<String> TemperatureTooHigh;
        public void Measure(int value)
        {
            Console.WriteLine($"Temperature measured: {value}°C");
            if (value > 100)
            {
                TemperatureTooHigh?.Invoke($"!! Temperature {value}°C goes higher then the recommented value 100°C ");
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
