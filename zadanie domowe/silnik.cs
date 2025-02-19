public class Silnik
{
    public bool CzyWlaczony;
    private int moc;
    public void ZmienMoc(int wartosc)
    {
        if (CzyWlaczony == false)
        {
            Console.WriteLine("Silnik jest wyłączony, nie można zmienić mocy.");
        }
        else
        {
            moc += wartosc;
            Console.WriteLine($"Aktualna moc to {moc}");
        }
    }
}