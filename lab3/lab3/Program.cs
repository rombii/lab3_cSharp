using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> list = new List<Osoba>();
            Osoba osoba1 = new Osoba();
            osoba1.imie = "Jan";
            osoba1.nazwisko = "Kowalski";
            Osoba osoba2 = new Osoba();
            osoba2.imie = "Janina";
            osoba2.nazwisko = "Kowalska";
            Osoba osoba3 = new Osoba();
            osoba3.imie = "Andrzej";
            osoba3.nazwisko = "Pandrzej";
            list.Add(osoba1);
            list.Add(osoba2);
            list.Add(osoba3);
            Console.WriteLine(list[0].ZwrocPelnaNazwe() + " " + list[1].ZwrocPelnaNazwe() + " " + list[2].ZwrocPelnaNazwe());
        }       
    }
}