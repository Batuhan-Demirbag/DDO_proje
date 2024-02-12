using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Facebook'ta bir mesaj gönderdiğinizde, gönderinizi beğenen kişi sayısına bağlı olarak Facebook farklı bilgiler görüntüler.

Gönderinizi kimse beğenmezse hiçbir şey görüntülenmez.
Gönderinizi yalnızca bir kişi beğenirse şu mesaj görüntülenir: [Arkadaşın Adı] gönderinizi beğendi.
Gönderinizi iki kişi beğenirse şu görüntülenir: [Arkadaş 1] ve [Arkadaş 2] gönderinizi beğendi.
Gönderinizi ikiden fazla kişi beğenirse şu görüntülenir: [Arkadaş 1], [Arkadaş 2] ve [Diğer Kişilerin Sayısı] diğerlerinin gönderinizi beğendiği.
Bir program yazın ve kullanıcı Enter tuşuna basana kadar (isim vermeden) sürekli olarak kullanıcıdan farklı isimler girmesini isteyin.
Sağlanan ad sayısına bağlı olarak yukarıdaki modele göre bir mesaj görüntüleyin.
 */
namespace ConsoleApp1.Dersler3
{
    class Example
    {
        public static void facebook()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Bir isim girin (çıkmak için enter): ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))  // isim boş girildiyse durdur
                {
                    break;
                }

                names.Add(input);  // isim girildiyse listeye ekler
                DisplayMessage(names);
            }
        }

        public static void DisplayMessage(List<string> names)
        {
            int count = names.Count;

            if (count == 1)
            {
                Console.WriteLine($"{names[0]} gönderinizi beğendi.");
            }
            else if (count == 2)
            {
                Console.WriteLine($"{names[0]} ve {names[1]} gönderinizi beğendi.");
            }
            else if (count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} ve diğer {count - 2} kişi gönderinizi beğendi.");
            }
            // 0 durumu için bir şey yapmaya gerek yok, çünkü hiçbir şey gösterilmeyecek.
        }
    }
}
