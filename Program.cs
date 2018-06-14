using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Create("sravya", "guddati");
            Print();
            Sub(56, 45);
            String result = Names("sravya", "Guddati");
            Console.WriteLine(result);
            Console.ReadKey();
          
        }

        // Using public
        public static void Create ( String a, String b )
        {
            
            Console.WriteLine(a + b);

        }
        public static void Print()
        {
            Console.WriteLine("i am using public");
        }

        //using return
        public static String Names (String c, String d)
        {
            return c + d;
        }

        //using private
        private  static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }




    }
}
