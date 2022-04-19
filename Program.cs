using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı yazınız:");
            string soyad = Console.ReadLine();
            Console.WriteLine(name+" "+soyad);
        }
    }
}
