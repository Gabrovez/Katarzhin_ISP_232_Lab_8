namespace Katarzhin_ISP_232_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ivan";
            string personName = person.Name;
            Console.WriteLine(personName);
            Person personb = new Person();
            Console.WriteLine(person.Age);
            person.Age = 37;
            Console.WriteLine(person.Age);
            person.Age = -37;
            Console.WriteLine(person.Age);

        }
    }
}
