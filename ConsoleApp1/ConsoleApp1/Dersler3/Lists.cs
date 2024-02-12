using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dersler3
{
    class Lists
    {
        public static void listadd()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            numbers.Add(5);  // listenin sonuna 5 ekler 
            numbers.AddRange(new List<int>(){6 , 7, 8 ,9});   // yeni liste ekleme 
            numbers.Remove(5);   // 5 sayıını listeden sil

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }

    }
}
