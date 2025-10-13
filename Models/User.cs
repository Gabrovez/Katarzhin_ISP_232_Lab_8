using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string email { get; set; }
        public bool IsActice { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, Почта: {email}, Активен: {IsActice}");
        }
    }
}
