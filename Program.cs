using System;

namespace c_sharp_course
{

    //hi this is some practice for @ashkanRmk c# course...  q:-)
    class Program
    {
        static void Main(string[] args)
        {
            
           Physagoras();
        


        }

        //a method for calculating a triangle hypotenuse  
        private static void Physagoras()
        {
            Console.WriteLine("please enter the A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter The B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            double sum = Math.Pow(A, 2) + Math.Pow(B, 2);
            double hypotenuse = Math.Sqrt(sum);
            
            Console.WriteLine($"\n THIS IS Hypotenuse:{hypotenuse}");
        }
        
        //practice for convert numbers
        private static void AB()
        {
            System.Console.WriteLine("please enter a number as A:");
            double A = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("\nplease enter a number as B:");
            double B = Convert.ToDouble(Console.ReadLine());

            double sourat = Math.Pow(A, 3);
            double makhraj = Math.Pow(A, 2) + 2 * (Math.Pow(B, 2)) + 5;

            double result = sourat / makhraj;

            System.Console.WriteLine($"\nthe result is {result}");
            System.Console.WriteLine(string.Format("{0:0.00}", result));
        }

        //Draw with C#
        private static void Pyramid_Method()
        {
            Console.Write("\n   *\n  ***\n *****\n*******");
            Console.WriteLine("\n------------");
            Console.Write("*\n**\n* *\n*  *\n*   *\n*    *\n*******");
            Console.WriteLine("\n------------");
            Console.Write("   *\n  * *\n *   *\n*******");
            Console.WriteLine("\n------------");
            Console.Write("   *\n  * *\n *   *\n*     *\n *   *\n  * *\n   *");
        }

        //practice for input
        public static void GetNameAndAge()
        {
            Console.WriteLine("please enter your name below :");
            string name = Console.ReadLine();

            Console.WriteLine("\nplease enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"your name is:{name} and you are {age} years old");

        }
    }
}
