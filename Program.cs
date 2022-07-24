namespace SwapElephants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            while (true)
            {
                string usr_choice = Console.ReadLine();
                Console.WriteLine($"You pressed {usr_choice}");
                if (usr_choice == "1")
                {
                    Console.WriteLine("Calling lloyd.WhoAMi()");
                    lloyd.WhoAmI();
                }
                else if (usr_choice == "2")
                {
                    Console.WriteLine("Calling lucinda.WhoAMi()");
                    lucinda.WhoAmI();
                }
                else if (usr_choice == "3")
                {
                    Console.WriteLine("References have been swapped");
                    Elephant dummy = lloyd;
                    lloyd = lucinda;
                    lucinda = dummy;

                }
                else if (usr_choice == "4")
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else
                {
                    return;
                }
            }
            
        }
    }
}