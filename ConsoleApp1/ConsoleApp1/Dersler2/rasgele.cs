using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ConsoleApp1.Dersler2
{

    // Rasgele 10 dizilik bir array döner
    class rasgele
    {
        public static void random()
        {
            Random random = new Random();
            var buffer = new char[10];

            for (var i = 0; i < 10; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
