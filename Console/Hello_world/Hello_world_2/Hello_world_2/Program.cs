
using System;

namespace Hello_world_2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //varibale
            String Greating = "Hi ,How are you? ^^";
            String Name = ("Sir");

            Console.WriteLine("");
            Console.WriteLine(Greating);
            Console.WriteLine(Name + ", Whold you like drink a cub of japaneses tea from my Miku?");
            
            //varaibale
            int Cup_Count = (2);
            float Cup_Price = (4.54f);

            //
            Console.WriteLine();
            Console.WriteLine("Totel Price" + " $");
            Console.WriteLine(Cup_Price * Cup_Count);

            //var
            int a = 1;
            int b = 4;
            
            int c = a + b;
            Console.WriteLine("Old Result was :" + c);

            a = 5;
            c = a + b;
            Console.WriteLine("New Result is :" + c);



        }   

    }
}