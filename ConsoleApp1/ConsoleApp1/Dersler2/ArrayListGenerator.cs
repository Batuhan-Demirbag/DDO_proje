using System;
using System.Collections;

namespace ConsoleApp1.Dersler2
{
    class MyClass
    {
        // ArrayList döndüren statik metod
        public static ArrayList CreateArrayList()
        {
            ArrayList list = new ArrayList();

            // Çeşitli tiplerde öğeler ekleyin
            list.Add(1); // Int
            list.Add("iki"); // String
            list.Add(3.14); // Double
            list.Add(true); // Boolean
            list.Add(DateTime.Now); // DateTime
            list.Add(new int[] { 5, 6, 7 }); // Int Array

            return list;
        }

        // ArrayList içindeki öğeleri ekrana yazdıran statik metod
        public static void PrintArrayList(ArrayList list)
        {
            foreach (var item in list)
            {
                if (item is int[])
                {
                    Console.Write("Dizi: ");
                    foreach (var i in (int[])item)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine(); // Diziyi yazdırdıktan sonra yeni satıra geç
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

}