namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persom ahri = new();
            Persom brand = new("Brand");
            Persom darius = new("Darius", 25);
            ahri.Print(); 
            brand.Print(); 
            darius.Print(); 
        }
        struct Persom
        {
            public string name; public int age;
            public Persom()
            {
                name = "Undefined";
                age = 18;
            }
            public Persom(string name = "Tom", int age = 1) 
            {
                this.name = name; this.age = age;
            }
            public void Print()=> Console.WriteLine($"Имя: {name} Возраст: {age}");
            
        }
    }
}
