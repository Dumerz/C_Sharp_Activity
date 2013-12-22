using System;

namespace Loops
{
    class Interface
    {
        public static void Main(string[] args)
        {
            Mechanism function = new Mechanism();
            
            Console.Write("\nEnter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWhile Loop");
            function.while_loop(num);

            Console.WriteLine("\nDo While Loop");
            function.do_while_loop(num);

            Console.WriteLine("\nFor Loop");
            function.for_loop(num);

            Console.Write("\nPress Any Key to Exit");
            Console.Read();
        }
    }

    class Mechanism
    {
        public void while_loop(int a)
        {
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
        }

        public void do_while_loop(int a)
        {
            do
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            } while (a < 20);
        }

        public void for_loop(int a)
        {
            for (int b = a; a < 20; a++)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            } while (a < 20);
        }
    
    }

}