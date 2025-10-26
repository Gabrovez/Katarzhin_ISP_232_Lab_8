using HtmlAgilityPack;
using MyApp.Models;
using MyClass;
using Newtonsoft.Json;
using static Katarzhin_ISP_232_Lab_8.SmartHome;
using MathLibrary;
using System.ComponentModel;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program{
        static async Task Main(){
            Console.Write("Enter site's url: ");
            string? url = Console.ReadLine();
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    HtmlWeb web = new HtmlWeb();

                    HtmlDocument doc = new HtmlDocument();
                    doc = await web.LoadFromWebAsync(url);
                    var titleNode = doc.DocumentNode.SelectSingleNode("//title");
                    if (titleNode != null)
                    {
                        Console.WriteLine($"Title of the page: {titleNode.InnerText}");
                    }
                    else
                    {
                        Console.WriteLine($"Title of the page is nowhere to be found");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }


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
