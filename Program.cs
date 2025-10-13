namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a;
            b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Person p1 = new Person();
            p1.name = "Denis";
            Person p2 = p1; // р2 указывает на тот же объект р1
            p2.name = "Anton";
            Console.WriteLine(p1.name); // Anton
            Console.WriteLine(p2.name);
        }
        /*struct Persom
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
            
        }*/
        class Person
        {
            public string? name;

        }
        void Ex()
        {
            int x = 5;
            int[] arr = new int[100];
        }
    }
}
