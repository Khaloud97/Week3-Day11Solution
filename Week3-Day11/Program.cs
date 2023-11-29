using System.Threading.Channels;

namespace Week3_Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Humen System!");


            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: "); //what if user enter string or more than 100 or less than 0
            string sage;
            int.TryParse(Console.ReadLine(), out int age);//will chack the user value

            Console.Write("Enter your Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter your E-Mail: ");
            string email = Console.ReadLine();

            Human hum = new Human(name, age, address, email);
            Console.WriteLine($"\nYour informaition: \n {hum.GreetingByName()} \n");
            Console.WriteLine("------------------");



            Human humen1 = new Human("Khaloud", 26, "Albatinah", "hamedKhaloud71@gmail.com");
            Console.WriteLine(humen1.GreetingByName());
            Console.WriteLine("------------------\n");

            //read from constrautre write it  between()
            Human humen2 = new Human(name: "Sara", age: 22, address: "Muscat", email: "Sara353@gmail.com");
            Console.WriteLine(humen2.GreetingByName());

            Console.WriteLine("------------------\n");
            //read from object inslization write it  between{}
            Human humen3 = new Human{ name = "Hamed", age = 50, address = "Albatinah"};
            Console.WriteLine("-----------befor set and get");
            Console.WriteLine(humen3.GreetingByName());


            Console.WriteLine("\n----------After  email set and get:\n");
            humen3.SetEmail("Hamed@gmail.com");//set for email becouse it was privet
            Console.WriteLine(humen3.GetEmail(email));
            Console.WriteLine(humen3.GreetingByName());

            //-----------------------------------------------------------------------
            Console.WriteLine("----------------------------------------------------------------------------");

           Console.WriteLine("--------Encabsulatin:----------\n");
            Human humen4 = new Human("Ail", 21, "Albatinah", "Ail876@gmail.com");
            // Console.WriteLine(humen4.GetEmail());
            Console.WriteLine("-------------befor set and get");
            Console.WriteLine(humen4.GreetingByName());

            Console.WriteLine("\n-----------After  email set and get:\n");
            humen4.SetEmail("Ali@gmail.com");
            Console.WriteLine(humen4.GetEmail(email));
            Console.WriteLine(humen4.GreetingByName());

        }
    }
}