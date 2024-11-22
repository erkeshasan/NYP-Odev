using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Üçgen Tabanı: ");
            double taban = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçgen Yüksekliği: ");
            double yükseklik = Convert.ToDouble(Console.ReadLine());

            Üçgen üçgenim = new Üçgen(taban, yükseklik);
            Console.Write("\nÜçgen Alanı: " + üçgenim.Alan() + "\n\n\n");
        }
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

        public double Alan() // Parametresiz metot?
        {
            return (Taban * Yükseklik) / 2;
        }
    }
}
