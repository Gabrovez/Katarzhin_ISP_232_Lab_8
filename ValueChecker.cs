using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katarzhin_ISP_232_Lab_8
{
    internal class ValueChecker
    {
        public void CheckType(object input)
        {
            switch (true)
            {
                case bool _ when input is int && input.GetType() == typeof(int): 
                    Console.WriteLine("Значимый тип: int"); 
                    break;
                case bool _ when input is double && input.GetType() == typeof(double): 
                    Console.WriteLine("Значимый тип: double"); 
                    break;
                case bool _ when input is float && input.GetType() == typeof(float): 
                    Console.WriteLine("Значимый тип: float"); 
                    break;
                case bool _ when input is decimal && input.GetType() == typeof(decimal): 
                    Console.WriteLine("Значимый тип: decimal"); 
                    break;
                case bool _ when input is bool && input.GetType() == typeof(bool): 
                    Console.WriteLine("Значимый тип: bool"); 
                    break;
                case bool _ when input is char && input.GetType() == typeof(char):
                    Console.WriteLine("Значимый тип: char"); 
                    break;
                case bool _ when input is long && input.GetType() == typeof(long): 
                    Console.WriteLine("Значимый тип: long"); 
                    break;
                case bool _ when input is short && input.GetType() == typeof(short): 
                    Console.WriteLine("Значимый тип: short"); 
                    break;
                case bool _ when input is string && input.GetType() == typeof(string): 
                    Console.WriteLine("Ссылочный тип: string"); 
                    break;
                case bool _ when input is object && input.GetType() == typeof(object): 
                    Console.WriteLine("Ссылочный тип: object"); 
                    break;
                default: Console.WriteLine("Неизвестный тип данных"); break;

            }
        }
    }
}
