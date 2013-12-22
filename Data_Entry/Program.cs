using System;

namespace Data_Entry
{
    class Interface
    {
        public static void Main(String[] args)
        {
            Processor function = new Processor();

            function.register();

            Console.Write("\n< press any Key to exit >");
            Console.ReadKey();
        }
    }

    class Processor
    {

        String input = "";

        public void register()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("\n First Name:\t");
            ask();
            Console.Write("\n Middle Name:\t");
            ask();
            Console.Write("\n Last Name:\t");
            ask();
            Console.Write("\n Contact No:\t");
            ask();
            Console.Write("\n Address:\t");
            ask();

        }

        public void ask()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}