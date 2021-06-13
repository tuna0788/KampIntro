using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Tuna", "Ahmet", "Engin", "Kazım" };

            //foreach (var name in names)
            //{
            //    Console.WriteLine("string : isimler " + name);
            //}

            //names = new string[4];
            //names[3] = "Tuğçe";
            //Console.WriteLine("isimler " + names[3]);
            //Console.WriteLine("isimler " + names[0]);

            Console.WriteLine("********************************");

            List<string> isimler = new List<string>{ "Esra", "Niko", "Murat" };
            Console.WriteLine(isimler[0]);
            isimler.Add("Demet");
            Console.WriteLine(isimler[3]);
        }
    }
}
