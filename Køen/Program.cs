using System;
using System.Collections.Generic;
using System.Linq;

namespace Køen
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Filmkø = new Queue<string>();
            bool filmliste;
            filmliste = true;
            while (filmliste)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("==============Filmlisten===============");
                Console.WriteLine("=======================================");
                Console.WriteLine();
                Console.WriteLine("1, tilføj en film");
                Console.WriteLine("2, fjern en film");
                Console.WriteLine("3, vis antal film i køen");
                Console.WriteLine("4, vis hvilke film der er i kø");
                Console.WriteLine("5, afslut");


                switchcase valg = new switchcase();
                string result = valg.Choice(int.Parse(Console.ReadLine()));
                Console.WriteLine(result);

                if (result == "Programmet afsluttes")
                {
                    filmliste = false;
                }



                else if (result == "Du har valgt at tilføje en film!")
                {
                    Console.WriteLine("Hvad er filmens titel?");
                    string Movie = Console.ReadLine();
                    Console.WriteLine($"Vi har nu tilføjet {Movie} til køen!");
                    Filmkø.Enqueue(Movie);
                    Console.ReadLine();
                }
                else if (result == "Du har set den næste film i rækken, og den vil blive fjernet fra køen")
                {
                    Filmkø.Dequeue();
                    Console.ReadLine();
                }
                else if (result == "Film i køen:")
                {
                    Console.WriteLine($"Film i køen: {Filmkø.Count}");
                    Console.ReadLine();
                }
                else if (result== "Disse film er tilbage i køen")
                {
                    var Filmliste = Filmkø.ToList();
                    foreach (var film in Filmliste)
                    {
                        Console.WriteLine();
                        Console.WriteLine(film);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}

