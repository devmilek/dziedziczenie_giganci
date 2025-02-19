public class Ciezarowka : Pojazd
{
    public int LadownoscPrzeczepy;

    public Ciezarowka(int moc, string kolor, string marka, int iloscKol, int ladownoscPrzyczepy) : base(moc, kolor, marka, iloscKol)
    {
        LadownoscPrzeczepy = ladownoscPrzyczepy;
    }
}