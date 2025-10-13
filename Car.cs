using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"{Brand} {Model} {Year} года выпуска с пробегом {Mileage}км.");  
        }
    }
}
