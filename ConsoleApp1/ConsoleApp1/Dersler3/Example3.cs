using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Kullanıcıdan 5 benzersiz sayı girmesini isteyen ve bu sayıları sıralayıp konsolda görüntüleyen bir C# programı yazalım.
 * Bu programda, kullanıcıdan sayıları alırken, girilen sayının daha önce girilip girilmediğini kontrol edeceğiz.
 * Eğer sayı daha önce girilmişse, bir hata mesajı gösterip, kullanıcıdan yeniden bir sayı girmesini isteyeceğiz.
 * 5 benzersiz sayı alındıktan sonra, bu sayıları sıralayıp ekrana yazdıracağız.
 */

namespace ConsoleApp1.Dersler3
{
    class Example3
    {
        public static void notequal()
        {
            List<int> sayilar = new List<int>();

            while (sayilar.Count < 5)
            {
                Console.Write("Lütfen bir sayı girin: ");
                int sayi;
                if (int.TryParse(Console.ReadLine(), out sayi))
                {
                    if (sayilar.Contains(sayi))
                    {
                        Console.WriteLine("Bu sayı zaten girildi. Lütfen başka bir sayı girin.");
                    }
                    else
                    {
                        sayilar.Add(sayi);
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz bir giriş. Lütfen bir sayı girin.");
                }
            }

            //Listeyi sırala
            sayilar.Sort();
            Console.WriteLine("Girilen dizi sıralaması: ");
            foreach (var sayı in sayilar)
            {
                Console.WriteLine(sayı);
            }
        }
    }
}
// int.TryParse kullanılarak girilen değerin geçerli bir int olup olmadığı kontrol edilir
// List.Contains metodu   bu değerin numbers listesinde olup olmadığı kontrol eder