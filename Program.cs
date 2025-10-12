namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Ясуо", 120);
            Console.WriteLine($"Имя героя: {hero.Name}\nУровень героя: {hero.Level}\nМана(или заряд пасивки): {hero.Mana}\nСтатус: {hero.Status}");
            hero.TakeDamage(50);
            hero.Heal(30);
            hero.TakeDamage(200);
            hero.Heal(50);
            hero.TakeDamage(200);


        }
    }
}
