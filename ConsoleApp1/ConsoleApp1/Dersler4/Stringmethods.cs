using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dersler4
{
    class Stringmethods
    {
        public static void method()
        {

            string example = "Hello, World!";

            // Length
            Console.WriteLine("Length: " + example.Length);

            // ToUpper ve ToLower
            Console.WriteLine("ToUpper: " + example.ToUpper());
            Console.WriteLine("ToLower: " + example.ToLower());

            // Substring
            Console.WriteLine("Substring(0, 5): " + example.Substring(0, 5));

            // Replace
            Console.WriteLine("Replace('World', 'C#'): " + example.Replace("World", "C#"));

            // Contains
            Console.WriteLine("Contains('World'): " + example.Contains("World"));

            // IndexOf
            Console.WriteLine("IndexOf('World'): " + example.IndexOf("World"));

            // Trim
            string spacedString = "  Hello, World!  ";
            Console.WriteLine("Trim: '" + spacedString.Trim() + "'");
        }

    }
}
