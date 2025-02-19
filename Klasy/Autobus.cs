public class Autobus : Pojazd
{
    public int IloscOsob;

    public void otworzDrzwi()
    {
        Console.WriteLine("Drzwi otwarte...");
    }

    public override void uruchomSilnik()
    {
        Console.WriteLine("Silnik autobusu uruchomiony...");
    }

    public Autobus(int moc, string kolor, string marka, int iloscKol, int iloscOsob) : base(moc, kolor, marka, iloscKol)
    {
        IloscOsob = iloscOsob;
    }
}