using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 30;

            Console.WriteLine("Sayının değeri :"+number1);

            Console.WriteLine("*************************");

            int[] numbers1 = new int[] {1,2,3,4,5,6 };
            int[] numbers2 = new int[] {10,20,30,40,50,60 };
            numbers1 = numbers2;
            numbers2[0] = 100;
            numbers2[0] = 999;

            Console.WriteLine("Sayıları 1'in değeri : "+numbers1[0]);
     
        } 
    }
}
