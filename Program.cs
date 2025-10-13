namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company microsoft = new("Microsoft");
            Person tom = new("Tom", microsoft);
            tom.Print();
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
    }
}
