using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Tuna");
            isimler.Add("Kazım");

            Console.WriteLine(isimler[0]);


        }
    }
}
