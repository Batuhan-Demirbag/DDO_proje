using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Bir program yazın ve kullanıcıdan adını girmesini isteyin.
 * Adı tersine çevirmek için bir dizi kullanın ve ardından sonucu yeni bir dizede saklayın.
 * Tersine çevrilmiş adı konsolda görüntüleyin.
 */
namespace ConsoleApp1.Dersler3
{
    class Example2
    {
        public static void Reverse()
        {
            // Kullanıcıdan adını girmesini iste
            Console.Write("Lütfen adınızı girin: ");
            string ad = Console.ReadLine();

            // Adı bir char dizisine çevir
            char[] adDizisi = ad.ToCharArray();

            // Diziyi ters çevir
            Array.Reverse(adDizisi);

            // Ters çevrilmiş diziyi bir stringe dönüştür
            string tersAd = new string(adDizisi);

            // Ters çevrilmiş adı görüntüle
            Console.WriteLine("Adınızın ters çevrilmiş hali: " + tersAd);
        }
    }
}
