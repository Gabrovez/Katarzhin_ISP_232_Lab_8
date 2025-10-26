using HtmlAgilityPack;
using MyApp.Models;
using MyClass;
using Newtonsoft.Json;
using static Katarzhin_ISP_232_Lab_8.SmartHome;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program{
        static void Main(string[] args){
            var tempSensor = new TemperatureSensor();
            var msensor = new MotionSensor();
            var slig = new SmartLight();

            tempSensor.OnOverheat += Notifier.SendTemperatureAlert;
            msensor.OnMotiondet += Notifier.LogMotionEvent;
            msensor.OnMotiondet += slig.On;

            Console.WriteLine("=== Simulation of smart house ===");
            tempSensor.CheckTemperature(15);
            tempSensor.CheckTemperature(35);
            msensor.DetectMotion(false);
            msensor.DetectMotion(true);

            msensor.DetectMotion(true);
            slig.On("motion detecred");
            Thread.Sleep(3000);
            slig.Off();



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
