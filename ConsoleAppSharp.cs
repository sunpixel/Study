Output users = new Output();
users.get_name_age();
users.print_data();

class Output
{
    string name = null;
    int age = 0;

    public void get_name_age()
    {
        Console.WriteLine("Please enter your name:\t");
        name = Console.ReadLine();
        Console.WriteLine("Please enter your age:\t");
        age = int.Parse(Console.ReadLine());
    }

    public void print_data()
    {
        Console.WriteLine($"Hi {name}, we welcome you to our bar.");
        if (age >= 18)
        {
            Console.WriteLine($"What would you like to drink {name}?");
        }
        else
        {
            Console.WriteLine($"{name} you are too young to drink yet.");
        }
    }
}



