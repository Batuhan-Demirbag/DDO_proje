using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dersler3
{
    class Arrays
    {
        public static void arraysfonction()
        {

            var numbers = new int[] { 1, 2, 3, 9, 15, 57, 23 };

            // Lenght
            Console.WriteLine("UZUNLUĞU: " + numbers.Length);

            // index elemanı
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index of eleman 9 : " + index);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Copy array: ");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // son oluşan
            Array.Sort(numbers);
            Console.WriteLine("son oluşan:");
            foreach (var c in numbers)
            {
                Console.WriteLine(c);
            }
        }
    }
}



