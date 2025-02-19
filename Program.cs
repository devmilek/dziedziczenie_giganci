public class Program
{
    public static void Main()
    {
        SamochodOsobowy samochod = new SamochodOsobowy(2, "czerwony", "Fiat", 5);
        Ciezarowka ciezarowka = new Ciezarowka(2, "niebieski", "Volvo", 6, 1000);
        Autobus autobus = new Autobus(6, "zielony", "Mercedes", 10, 50);

        autobus.uruchomSilnik();
        samochod.uruchomSilnik();

        Console.WriteLine("Wynik metody ToString(): " + samochod.ToString());
    }
}