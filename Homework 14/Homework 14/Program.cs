using System;

namespace Homework_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating variables
            String Hellokitty = "pink";
            String name = "hellokitty";
            int x = 23;
            float y = 3.4F;
            double z = 2.4D;
            bool a = true;

            // printing them to console
            Console.WriteLine(Hellokitty);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.ReadKey();

            //string interpolation
            Console.WriteLine("my fav toy is in {0} and its name is {1} and its age is{2}" ,Hellokitty, name, x);
            Console.ReadKey();

            //user input
            Console.Write("What is your fav character: ");
            String Character = Console.ReadLine();
            Console.WriteLine(Character);
            Console.ReadKey();

            //relational operators
            Console.WriteLine(9 > 12);
            Console.WriteLine("good" == "bad");
            Console.WriteLine("hi" == "hi");
            Console.WriteLine(2 < 6);
            Console.ReadKey();



        }
    }
}
