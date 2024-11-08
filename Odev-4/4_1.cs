while (true)
{
    Console.Write("Üçgen Tabanı: ");
    double taban = Convert.ToDouble(Console.ReadLine());

    Console.Write("Üçgen Yüksekliği: ");
    double yükseklik = Convert.ToDouble(Console.ReadLine());

    Üçgen üçgen = new Üçgen(taban, yükseklik);

    Console.Write("\nÜçgen Alanı: " + üçgen.Alan() + "\n\n");
}

class Üçgen
{
    public double Taban;
    public double Yükseklik;

    public Üçgen(double taban, double yükseklik)
    {
        Taban = taban;
        Yükseklik = yükseklik;
    }

    public double Alan()
    {
        return (Taban * Yükseklik) / 2;
    }
}
