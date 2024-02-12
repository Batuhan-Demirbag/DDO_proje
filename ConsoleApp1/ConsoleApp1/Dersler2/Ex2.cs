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
        public static void RandomSort()
        {
            Console.WriteLine("Virgülle ayrılmış sayıları girin:");
            string input = Console.ReadLine();

            // Girilenleri virgülle ayır ve int'e çevir
            string[] numbers = input.Split(',');

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            foreach (var number in numbers)
            {
                // Sayıyı temizle ve int'e çevir
                int currentNumber = Convert.ToInt32(number.Trim());

                // Maksimum sayıyı güncelle
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }

                // Minimum sayıyı güncelle
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }

            Console.WriteLine("En büyük sayı: " + maxNumber);
            Console.WriteLine("En küçük sayı: " + minNumber);
        }
    }
}
