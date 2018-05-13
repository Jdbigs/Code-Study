using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloJT
{
    class Program
    {
        static void Main(string[] args)
        {
            // listing 1.1 hello.cs 
            System.Console.WriteLine("  welcome to C # programming James Taylor");
            System.Console.ReadLine();

            // Exercise 2 in chapter 1

            // declare variables
            int radius = 4;
            const double PI = 3.14159;
            double circum, area;

            // do calculation

            area = PI * radius * radius;
            circum = 2 * PI * radius;


            // print the results

            Console.WriteLine("Radius = {0}, PI = {1}",radius, PI);
            Console.WriteLine("the area is {0},", area);
            Console.WriteLine("The Circumference is {0}", circum);
            Console.ReadLine();


            // exercise 3
            int x, y;
            for (x = 0; x < 10; x++, System.Console.Write("\n"))
                for (y = 0; y < 10; y++)
                    System.Console.Write("X");
            Console.ReadLine();

            // exericise 4 

            Console.WriteLine("Keep Looking");
            Console.WriteLine("Youll find it!");
            Console.ReadLine();


            
            for (x = 0; x < 10; x++, System.Console.Write("\n"))
                for (y = 0; y < 10; y++)
                    System.Console.Write("{0}", (char) 2 );
            Console.ReadLine();

        }
    }
}
