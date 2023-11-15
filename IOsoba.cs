namespace MojaAplikacja
{
    public interface IOsoba
    {
        int Id { get; set; }
        string Imie { get; set; }
        string Nazwisko { get; set; }
        DateOnly Data_Urodzenia { get; set; }
    }
}
