using System;

namespace CSharp___Exercise_4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = GetInput();
            input = SmileyFace( input );
            input = FrownyFace( input );
            WriteName( input );

           // Console.WriteLine("Please enter your name: ");
           
           // string myname = Console.ReadLine(); 
           
           // Console.WriteLine (":( " +myname+ " :)" );
        }
        
        static void WriteName(string input)
        {
            Console.WriteLine( input );
        }

        static string GetInput()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }

        static string SmileyFace(string input)
        {
            input = input + " :)";
            return input;
        }

        static string FrownyFace( string input)
        {
            input = ":( " + input;
            return input;    
        }
    }
}
