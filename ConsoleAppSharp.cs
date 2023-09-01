using System;

namespace Programm1
{
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
                else if (a == 4) { Console.WriteLine($"There are no possibilities to edit stats yet.\n"); tru = false; }
                else
                {
                    Console.WriteLine($"You entered invalid code: {a}.\n");
                    Console.WriteLine("Please enter a valid number from 0 to 4\n" +
                    "0 to end. 1 - 3 to view parameters 4 to edit them\n");
                    a = Console.Read();
                }
            }
        }
    }
}
