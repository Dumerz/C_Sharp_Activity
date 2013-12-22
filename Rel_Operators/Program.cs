using System;

namespace Relational_Operators
{
    class front_end
    {
        public static void Main(string[] args)
        {
            back_end function = new back_end();

            Console.Write("\nEnter your first number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter your second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            function.compare(a, b);

            Console.Write("\n<Press Enter to continue>");
            Console.ReadLine();

        }
    }

    class back_end
    {
        public void compare(int a, int b)
        {
            String c = "";
            if (a == b)
                c = "is equal to";
            else
                c = "is not equal to";
            Console.WriteLine("\nLine 1 - {0} {1} {2}", a, c, b);

            if (a > b)
                c = "is greater than";
            else
                c = "is not greater than";
            Console.WriteLine("Line 2 - {0} {1} {2}", a, c, b);

            if (a < b)
                c = "is less than";
            else
                c = "is not less than";
            Console.WriteLine("Line 3 - {0} {1} {2}", a, c, b);
        }
    }
}