namespace lab3;

public class ListaOsob : IListaOsob
{
    public readonly List<Osoba> List;

    public void wypiszOsoby()
    {
        foreach (IOsoba osoba in List)
        {
            Console.WriteLine(osoba.ZwrocPelnaNazwe());
        }
    }
    public void PosortujOsobyPoNazwisku()
    {
        List.Sort((osoba, osoba1) => String.CompareOrdinal(osoba.nazwisko, osoba1.nazwisko));
    }

    public ListaOsob()
    {
        List = new List<Osoba>();
    }
}