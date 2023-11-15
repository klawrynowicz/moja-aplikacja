namespace MojaAplikacja
{
    public class Pracownik : Osoba, IPracownik
    {
        public DateOnly Data_Zatrudnienia { get; set; }

        public Pracownik(int id, string imie, string nazwisko, DateOnly dataUrodzenia, DateOnly dataZatrudnienia)
            : base(id, imie, nazwisko, dataUrodzenia)
        {
            Data_Zatrudnienia = dataZatrudnienia;
        }
    }
}
