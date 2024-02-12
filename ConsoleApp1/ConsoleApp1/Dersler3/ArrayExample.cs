using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dersler3
{
    class ArrayExample
    {
        /*
         Adım 1: Array Boyutunu Kullanıcıdan Alma
           İlk olarak, kullanıcının kaç sayı gireceğini belirlemesi için bir sayı isteyin. Bu sayı, arrayimizin boyutunu belirleyecek.
           
           Adım 2: Sayıları Saklamak İçin Bir Array Oluşturma
           Kullanıcının belirttiği boyutta bir int arrayi oluşturun.
           
           Adım 3: Kullanıcıdan Sayıları Alma ve Arrayi Doldurma
           Daha sonra, bir döngü kullanarak kullanıcıdan bu sayıları tek tek alın ve oluşturduğunuz arraye yerleştirin.
           
           Adım 4: Arraydeki Sayıların Ortalamasını Hesaplama
           Tüm sayılar arraye yerleştirildikten sonra, bir başka döngü kullanarak tüm sayıların toplamını hesaplayın ve sayı adedine bölerek ortalamayı bulun.
           
           Adım 5: Ortalamayı Ekrana Yazdırma
           Son olarak, hesaplanan ortalamayı ekrana yazdırın.
           
         */
        public static void addarray()
        {
            Console.WriteLine("Arrayin boyutunu gir: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[size];

            for (int i = 0; i < size ; i++)
            {
                Console.WriteLine($"{i+1}. sayıyı giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam = toplam + sayi;
            }

            double ortalama = (double)toplam / size;
            Console.WriteLine($"Girilen sayıların ortalaması: " + ortalama);
        }
    }
}
