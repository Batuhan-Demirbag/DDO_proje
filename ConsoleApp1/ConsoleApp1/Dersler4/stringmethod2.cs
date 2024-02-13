using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dersler4
{
    class stringmethod2
    {
        public static void method()
        {
            string str1 = "";
            string str2 = null;
            string str3 = "Hello World";

            bool result1 = String.IsNullOrEmpty(str1); // true
            bool result2 = String.IsNullOrEmpty(str2); // true
            bool result3 = String.IsNullOrEmpty(str3); // false

            Console.WriteLine(result1); // Çıktı: true
            Console.WriteLine(result2); // Çıktı: true
            Console.WriteLine(result3); // Çıktı: false


            string st = "   ";
            string st2 = "\t\n";
            string st3 = "Hello World";

            bool res1 = String.IsNullOrWhiteSpace(str1); // true
            bool res2 = String.IsNullOrWhiteSpace(str2); // true
            bool res3 = String.IsNullOrWhiteSpace(str3); // false

            Console.WriteLine(res1); // Çıktı: true
            Console.WriteLine(res2); // Çıktı: true
            Console.WriteLine(res3); // Çıktı: false
             

        }
    }
}
