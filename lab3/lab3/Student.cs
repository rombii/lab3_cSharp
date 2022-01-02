namespace lab3;

public class Student : IStudent
{
    public string imie { get; set; }
    public string nazwisko { get; set; }
    public string ZwrocPelnaNazwe()
    {
        return this.imie + " " + this.nazwisko;
    }

    public string uczelnia { get; set; }
    public string kierunek { get; set; }
    public int rok { get; set; }
    public int semestr { get; set; }

    public virtual string WypiszPelnaNazweIIczelnie()
    {
        return ZwrocPelnaNazwe() + ", " + this.semestr + this.kierunek + this.rok + this.uczelnia;
    }
}