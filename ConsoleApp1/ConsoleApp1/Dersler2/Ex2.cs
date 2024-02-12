using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// rasgele sayılar gir bu sayıları büyük ve küçük olanları yazdır

namespace ConsoleApp1.Dersler2
{
    class Ex2
    {
        static void Main()
        {
            Console.WriteLine("Virgülle ayrılmış sayıları girin:");
            string input = Console.ReadLine();

            // girilenleri virgülle ayır ve int çevir
            string[] number = input.Split(',');
            
            // başlangıçtaki sayıyı enküçük belirle arrayi gez
            int maxnumber = int.MinValue;
            int minnumber = int.MaxValue;

            foreach (var numbers in number)
            {
                int currentNumber = Convert.ToInt32(numbers.Trim());

                if (currentNumber > maxnumber)
                {
                    maxnumber = currentNumber;
                }
                else if (currentNumber < minnumber)
                {
                    minnumber = currentNumber;
                }

            }

            Console.WriteLine("max sayı: " + maxnumber);
            Console.WriteLine("min sayı: " + minnumber);
        }
    }
}
