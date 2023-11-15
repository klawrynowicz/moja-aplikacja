using System;
using System.Collections.Generic;
using System.Linq;

namespace MojaAplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            var pracownicy = new List<Pracownik>
            {
                // pracownicy
                new Pracownik(1, "Jan", "Kowalski", new DateOnly(1980, 1, 1), new DateOnly(2020, 1, 1)),
                new Pracownik(1, "Eryk", "Borkowski", new DateOnly(1979, 2, 3), new DateOnly(2020, 3, 4)),
                new Pracownik(1, "Borys", "Gajewska", new DateOnly(1983, 5, 7), new DateOnly(2019, 2, 3)),
                new Pracownik(1, "Kewin", "Cieślak", new DateOnly(1985, 1, 1), new DateOnly(2021, 5, 6)),
                new Pracownik(1, "Alex", "Kaczmrczyk", new DateOnly(1982, 5, 6), new DateOnly(2022, 3, 7)),
            };

            var inneOsoby = new List<Osoba>
            {
                // osoby
                new Osoba(6, "Anna", "Nowak", new DateOnly(1990, 2, 2)),
                new Osoba(6, "Roman", "Kowalczyk", new DateOnly(1989, 3, 5)),
            };

            Console.WriteLine("Podaj datę w formacie YYYY-MM-DD:");
            var data = DateOnly.Parse(Console.ReadLine());

            var wyfiltrowaniPracownicy = pracownicy.Where(p => p.Data_Zatrudnienia > data).ToList();

            Console.WriteLine("Pracownicy zatrudnieni po podanej dacie:");
            foreach (var pracownik in wyfiltrowaniPracownicy)
            {
                Console.WriteLine($"{pracownik.Id}. {pracownik.Imie} {pracownik.Nazwisko}");
            }
        }
    }
}