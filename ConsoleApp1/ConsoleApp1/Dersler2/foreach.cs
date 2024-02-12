using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dersler2
{
    class @foreach
    {
        public static void foreachs()
        {
            var name = "batuhan demirbag";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            //foreach
            foreach (var names in name)
            {
                Console.WriteLine(names);
            }

        }

    }
}
