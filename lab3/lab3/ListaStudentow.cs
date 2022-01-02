namespace lab3;

public class ListaStudentow : IListaOsob
{
    private List<Student> List;
    public void wypiszOsoby()
    {
        foreach (Student osoba in List)
        {
            osoba.WypiszPelnaNazweIIczelnie();
        }
    }

    public void PosortujOsobyPoNazwisku()
    {
        List.Sort((osoba, osoba1) => String.CompareOrdinal(osoba.nazwisko, osoba1.nazwisko));
    }

    public ListaStudentow()
    {
        List = new List<Student>();
    }
}