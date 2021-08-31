using System;

namespace Køen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool filmliste;
            filmliste = true;
            while (filmliste)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("==============Filmlisten===============");
                Console.WriteLine("=======================================");
                Console.WriteLine();
                Console.WriteLine("1, tilføj en film");
                Console.WriteLine("2, fjern en film");
                Console.WriteLine("3, vis antal film i køen");
                Console.WriteLine("4, vis hvilke film der er i kø");
                Console.WriteLine("5, afslut");

                int choice = int.Parse(Console.ReadLine());
            }
        }
    }
}
