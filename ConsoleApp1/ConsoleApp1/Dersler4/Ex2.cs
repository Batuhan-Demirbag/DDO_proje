using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Bir program yazın ve kullanıcıdan kısa çizgiyle ayrılmış birkaç sayı girmesini isteyin.
 * Kullanıcı herhangi bir giriş yapmadan yalnızca Enter'a basarsa hemen çıkın; aksi takdirde kopyaların olup olmadığını kontrol edin.
 * Öyleyse konsolda "Çoğalt" seçeneğini görüntüleyin
 */
namespace ConsoleApp1.Dersler4
{
    class Ex2
    {
        public static void ardışık()
        {
            Console.WriteLine("Lütfen kısa çizgiyle ayrılmış sayıları girin (çıkmak için boş bırakıp Enter'a basın):");
            string input = Console.ReadLine();

            // Kullanıcı boş bir giriş yaparsa programdan çık
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Programdan çıkılıyor...");
                return;
            }

            // Girişi parçalara ayır ve int dizisine dönüştür
            string[] parts = input.Split('-');
            int[] numbers = parts.Select(part => int.Parse(part)).ToArray();

            // Sayılar içinde kopyaların olup olmadığını kontrol et
            if (numbers.Length != numbers.Distinct().Count())
            {
                Console.WriteLine("Çoğalt");
            }
            else
            {
                Console.WriteLine("Kopya yok");
            }
        }
    }
}
