using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_8
{
    
    internal class SmartHome
    {
        public delegate void TemperatureEventHandler(string mes);
        public delegate void MotionEventHandler(string mes);

        public class TemperatureSensor
        {
            public event TemperatureEventHandler OnOverheat;
            public void CheckTemperature( int ct)
            {
                if (ct > 30)
                {
                    OnOverheat?.Invoke($"!! Critical temperature: {ct}°C");
                }
            }
        }
        public class MotionSensor
        {
            public event MotionEventHandler OnMotiondet;

            public void DetectMotion(bool IsMotion)
            {
                if (IsMotion)
                {
                    OnMotiondet?.Invoke($"!! Movement detected in corridor!");
                }
            }
        }
        public class Notifier
        {
            public static void SendTemperatureAlert(string message)
            {
                Console.WriteLine($" [Notification] {message}");
            }
            public static void LogMotionEvent(string message)
            {
                Console.WriteLine($" [Log] {message} (time: {DateTime.Now})");
            }
        }
        public class SmartLight
        {
            private bool isOn = false;
            public void On(string mes)
            {
                if (!isOn)
                {
                    isOn = true;
                    Console.WriteLine("[Light]! Turn on ( trigger: move)");
                }
            }
            public void Off()
            {
                if (isOn)
                {
                    isOn = false;
                    Console.WriteLine("[Light]! Turn off (time goes without any move)");
                }
            }
        }
    }
}
