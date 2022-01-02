namespace lab3;

public class Osoba : IOsoba
{
    public string imie { get; set; }
    public string nazwisko { get; set; }

    public string ZwrocPelnaNazwe()
    {
        return this.imie + " " + this.nazwisko;
    }
}