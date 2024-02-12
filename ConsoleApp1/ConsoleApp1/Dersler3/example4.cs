using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Bir program yazın ve kullanıcıdan sürekli olarak bir sayı girmesini isteyin veya çıkmak için "Çık" yazın.
 * Numara listesi kopyaları içerebilir. Kullanıcının girdiği benzersiz sayıları görüntüleyin
 */
namespace ConsoleApp1.Dersler3
{
    class example4
    {
        public static void examples()
        {
            List<int> uniqueNumbers = new List<int>();

            while (true)
            {
                Console.Write("Bir sayı girin veya çıkmak için 'Quit' yazın: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    uniqueNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin veya 'Quit' yazın.");
                }
            }

            Console.WriteLine("Girilen benzersiz sayılar:");
            foreach (var num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
