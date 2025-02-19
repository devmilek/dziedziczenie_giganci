public class Pojazd
{
    public int Moc;
    public string Kolor;
    public string Marka;
    public int IloscKol;

    public virtual void uruchomSilnik()
    {
        Console.WriteLine("Silnik uruchomiony...");
    }

    public void zatrzymajSilnik()
    {
        Console.WriteLine("Silnik zatrzymany...");
    }

    public Pojazd(int moc, string kolor, string marka, int iloscKol)
    {
        Moc = moc;
        Kolor = kolor;
        Marka = marka;
        IloscKol = iloscKol;
    }
}