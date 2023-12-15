using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 5;
            
            while (choice != 4)
            {
                Console.WriteLine("   ");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Print the rectangle");
                        Console.WriteLine("Enter the Length of the Rectangle");
                        int m = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Width of the Rectangle");
                        int n = Int32.Parse(Console.ReadLine());
                        for (int i = 1; i<= m; i++)
                        {
                        for (int j = 1; j <= n; j++)
                        {
                            Console.Write("*" + "  ");
                        }
                        Console.Write("\n");
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("2. Print the square triangle");
                        Console.WriteLine("Enter the Length of the Side");
                        int p = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Print the Bottom-Left square triangle");
                        for (int i = 1; i<= p; i++)
                        {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*" + "  ");
                        }
                        Console.Write("\n");
                        }
                        Console.WriteLine("Print the Top-Left square triangle");
                        for (int i = 1; i<= p; i++)
                        {
                        for (int j = p; j >= i; j--)
                        {
                            Console.Write("*" + "  ");
                        }
                        Console.Write("\n");
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("3. Print isosceles triangle");
                        Console.WriteLine("Enter the Height (numbers of rows of the stars) of the isosceles triangle");
                        int q = Int32.Parse(Console.ReadLine());
                        
                        for (int i = 0; i<=q; i++)
                        {
                        for (int j=1;j<=q-i;j++) Console.Write(" ");
                        for (int k = 1; k <= 2*i-1; k++) Console.Write("*");
                        Console.Write("\n");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
    }
}


