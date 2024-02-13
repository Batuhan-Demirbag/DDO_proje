using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  
    Bir program yazın ve kullanıcıdan kısa çizgiyle ayrılmış birkaç sayı girmesini isteyin. 
    Sayıların ardışık olup olmadığını öğrenin. 
    Örneğin, giriş "5-6-7-8-9" veya "20-19-18-17-16" ise şu mesajı görüntüleyin: 
                    "Ardışık"; aksi takdirde "Ardışık Değil" ifadesini görüntüleyin.
   
 */
namespace ConsoleApp1.Dersler4
{
    class ardışıksayı
    {
        public static void ardışık()
        {
            Console.WriteLine("Ardışık kontrolu yapmak için - ile sayıları girin:");
            string input = Console.ReadLine();


            //girilen sayoları - ile ayıran ve int diziye dönürşütürür
            string[] parts = input.Split('-');

            // girilen sayıların uzunluğunu alır
            int[] numbers = new int[parts.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }


            // Ardışık kontrolu
            bool ardışık = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    ardışık = false;
                    break;
                }
            }

            // Ardışık olanları yazdır
            if (ardışık == true)
            {
                Console.WriteLine("Ardışık sayılar: " + input);
            }
            else
            {
                Console.WriteLine("değilllll");
            }
        }
    }
}
