Console.WriteLine(Ortalama(1, 2));

static double Ortalama(params double[] sayılar)
{
    double toplam = 0;

    foreach (double sayı in sayılar)
    {
        toplam = toplam + sayı;
    }

    return toplam / sayılar.Length;
}
