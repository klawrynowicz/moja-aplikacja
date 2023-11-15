namespace MojaAplikacja
{
    public class Osoba : IOsoba
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateOnly Data_Urodzenia { get; set; }

        public Osoba(int id, string imie, string nazwisko, DateOnly dataUrodzenia)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Data_Urodzenia = dataUrodzenia;
        }
    }
}
