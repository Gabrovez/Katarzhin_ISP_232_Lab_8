using Base;
namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new("Tom");
            tom.print();
        }
    }
}
namespace Base
{
    class Person
    {
        string Name;
        public Person(string name) => Name = name;
        public void print() => Console.WriteLine($"Имя: {Name}");
    }
}
