using System;
using System.Collections;


class Program
{
    static void Main()
    {
        // Stirng dizisimdeki elemanların isimlerini yazdırma
        var name = "batu";
        string lastname = "demir";

        var fullname = name + "" + lastname;
        var myfullname = string.Format("My name {0} {1}\n",name , lastname);
        Console.WriteLine(myfullname);
        //output batu demir 

        // ikinci yol
        var names = new string[3] { "Volkan", "Biçen", "ddo" };
        var mynames = string.Join(",", names);
        Console.WriteLine(mynames);


        // üçüncü yol 
        string[] isimler = { "Arda", "Güler" ,"Ddo"};
        foreach(string i in isimler)
        {
            Console.WriteLine(i);
        }
    }
}