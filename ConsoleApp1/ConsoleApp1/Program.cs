using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hayvan
    {
        public Hayvan()
        {
            Console.WriteLine("Bir hayvan oluşturuldu.");
        }

        public void YemekYe()
        {
            Console.WriteLine("Hayvan yemek yiyor.");
        }
    }

    // Türetilmiş sınıf
    class Kedi : Hayvan
    {
       

        public void Miyavla()
        {
            Console.WriteLine("Kedi miyavlıyor.");
        }
    }

   
    

    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.YemekYe(); // Temel sınıftan miras alınan metod
            kedi.Miyavla();

           
        }
    }
}
