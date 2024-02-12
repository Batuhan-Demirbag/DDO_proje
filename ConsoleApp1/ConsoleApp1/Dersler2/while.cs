using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dersler2
{
    class dowhile
    {
        public static void whiles()
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.WriteLine("Lütfen bir isim girin (Çıkmak için boş bırakın):");
                var input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    names.Add(input); // isim girildiyse listeye eklenir
                    Console.WriteLine($"Eklendi : {input}");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("\n Girilen isim listesi");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
