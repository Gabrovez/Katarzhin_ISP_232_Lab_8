using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class Person
    {
        string name = "Tom";
        int age =  1;
        public int Age { set { age = value; } }
        public string Name { get { return name; } }
        public void Print() => Console.WriteLine($"Name: {name} Age: {age}");
    }
}
