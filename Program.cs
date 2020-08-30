using System;

namespace H1_Chewing_Gum_Dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispenser gumDispenser = new Dispenser(55, 25, 12, 20, 19, 14, 10);

            //Main menu
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ayup lad! Welcome to the machine!");
                Console.WriteLine("\nDo you want a chewing gum? (Y/N)");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'y':
                        Console.Clear();
                        string temp = gumDispenser.Draw();
                        if (temp.Equals("You've emptied the machine, you little bastard!"))
                        {
                            while (!gumDispenser.Full)
                            {
                                Console.Clear();
                                Console.WriteLine("You've emptied the machine, you little bastard!");
                                Console.WriteLine("Refill the machine? (Y/N)");
                                switch (Console.ReadKey(true).KeyChar)
                                {
                                    case 'y':
                                        gumDispenser.Refill();
                                        break;
                                    case 'n':
                                        Console.Clear();
                                        Console.WriteLine("\nOkay, chill weirdo");
                                        System.Threading.Thread.Sleep(1250);
                                        Environment.Exit(0);
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(temp);
                            System.Threading.Thread.Sleep(400);
                        }
                        break;
                    case 'n':
                        Console.Clear();
                        Console.WriteLine("\nOkay, chill weirdo");
                        System.Threading.Thread.Sleep(1250);
                        Environment.Exit(0);
                        break;
                }
                Console.Title = $"Gum left: {gumDispenser.Amount}";
            }
        }
    }
}
