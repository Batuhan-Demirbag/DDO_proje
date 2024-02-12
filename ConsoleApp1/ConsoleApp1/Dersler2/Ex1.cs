//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//// EX :RASGELE 1-10 arası sayı oluştur tahmin ettir bilirse kazandın yoksa kaybettin bastıran uygulama
//namespace ConsoleApp1.Dersler2
//{
//    class Ex1
//    {
//        static void Main()
//        {
//            // Initilaze random sayı
//            Random random = new Random();

//            int üretilensayı = random.Next(1, 10);

//            Console.WriteLine("Üretilen sayı: " + üretilensayı);

//            bool win = false;
//            // 4 tahmin hakkı var
//            for (int i = 0; i < 4; i++)
//            {
//                Console.Write("Tahmin et sayıyı (1-10) : ");

//                int guess = Convert.ToInt32((Console.ReadLine()));

//                // tahmin doğru ise
//                if (guess == üretilensayı)
//                {
//                    win = true;
//                    Console.WriteLine("Doğru tahmin koçummm");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Yanlış tahmin ettin baay");
//                }
//            }

//        }
//    }
//}