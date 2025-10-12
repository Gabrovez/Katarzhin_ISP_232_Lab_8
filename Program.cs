namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product { Name = "Яблоко", Price = 10.5m, Quantity = 5 };
            var banana = new Product { Name = "Банан", Price = 7.2m, Quantity = -2 };
            Console.WriteLine($"{apple.Name} x {apple.Quantity} = {apple.TotalPrice} Руб.");
            Console.WriteLine($"{banana.Name} x {banana.Quantity} = {banana.TotalPrice} Руб.");

        }
    }
}
