class Program
{
    static void Main()
    {
        Console.WriteLine(AritmetikOrtalama(4.2, 25.7));
        Console.WriteLine(AritmetikOrtalama(1, 2, 3, 4, 5));
    }

    static double AritmetikOrtalama(params double[] sayılar)
    {
        double toplam = 0;

        foreach (double sayı in sayılar)
        {
            toplam = toplam + sayı;
        }

        return toplam / sayılar.Length;
    }
}
