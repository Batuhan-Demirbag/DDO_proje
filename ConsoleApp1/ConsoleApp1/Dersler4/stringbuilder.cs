using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dersler4
{
    class stringbuilder
    {
        public static void builder()
        {
            // StringBuilder nesnesi oluştur
            StringBuilder sb = new StringBuilder();

            // Metin ekle
            sb.Append("Batuhan");
            sb.AppendLine(" Demirbag");
            sb.Append("This is a new line.");

            Console.WriteLine(sb.ToString());

            // Metin araya ekle
            sb.Insert(12, " inserted text");
            Console.WriteLine(sb.ToString());

            // Metin değiştir
            sb.Replace("World", "C#");
            Console.WriteLine(sb.ToString());

            // Metin sil
            sb.Remove(10, 14); // 10. pozisyondan başlayarak 14 karakter sil
            Console.WriteLine(sb.ToString());

            // StringBuilder'ı temizle
            sb.Clear();
            sb.Append("StringBuilder is now empty.");
            Console.WriteLine(sb.ToString());

        }
    }
}
