using System;

static void Main(string[] args)
{
    ORDER order = new ORDER();
    Console.WriteLine("1");
}


public class ORDER  // Sub-classes functioning to serve Main
{
    private int number = 0;
    private double total_value = 0;
    private int quantity = 0;
    private string status = "";

    public void Data_preview()
    {
        string num = "";
        int x = 0;
        int iter = 0;
        Console.WriteLine("Please enter your ORDER number: ");
        num = Console.ReadLine();
        x = Int32.Parse(num);
        Console.WriteLine(num.Length);
        while (iter < 3)
        {
            iter++;
            if (num.Length > 6)
            {
                if (x == number)
                {
                    Console.WriteLine($"ORDER number: {number}.\n");
                    break;
                }

                else
                {
                    Console.WriteLine($"Invalid ORDER number {number}.\n" +
                    $"Please try a different one\n");
                }
            }
            else
            {
                Console.WriteLine($"Invalid ORDER number {number}.\n" +
                    $"Please try a different one\n");
                Console.WriteLine("Enter number from 1 - 3 to view parameters 4 to edit them\n");
                options(Console.Read());
            }
        }
    }

    private void options(int a)
    {
        bool tru = true;
        while (tru)
        {
            if (a == 0) { break; }
            else if (a == 1) { Console.WriteLine($"Total value of your order is {total_value}.\n"); tru = false; }
            else if (a == 2) { Console.WriteLine($"There are a total of {quantity} in your order.\n"); tru = false; }
            else if (a == 3) { Console.WriteLine($"Status of your order is {status}.\n"); tru = false; }
            else if (a == 4) { edit_order(); tru = false; }
            else
            {
                Console.WriteLine($"You entered invalid code: {a}.\n");
                Console.WriteLine("Please enter a valid number from 0 to 4\n" +
                "0 to end. 1 - 3 to view parameters 4 to edit them\n");
                a = Console.Read();
            }
        }
    }

    private void edit_order()
    {
        Console.WriteLine($"You are currently editting order number: {number}\n");
        Console.WriteLine($"Edittable parameters are \n" +
        $"Value: {total_value}\n Quantity: {quantity}\n Status: {status}\n" +
        $"To edit them type numbers from 1 to 3 respectively to change the value\n");
        int a = 0;
        bool correct = false;
        while (!correct)
        {
            a = Console.Read();
            if (a == 1) { correct = true; Console.WriteLine($"Total value: {total_value}.\n"); Console.WriteLine("Please eneter new value:\n Total_Value = "); total_value = Console.Read(); }
            else if (a == 2) { correct = true; Console.WriteLine($"Quantity: {quantity}.\n"); Console.WriteLine("Please eneter new value:\n quantity = "); quantity = Console.Read(); }
            else if (a == 3) { correct = true; Console.WriteLine($"Status: {status}.\n"); Console.WriteLine("Please eneter new status:\n status = "); total_value = Console.Read(); }
            else if (a == 3) { correct = true; Console.WriteLine($"Status: {status}.\n"); Console.WriteLine("Please eneter new status:\n Status = "); status = Console.ReadLine(); }
            else { correct = false; Console.WriteLine($"{a} is not in the list!! \n Please Enter number from 1 to 3.\n"); }
        }
    }
}

