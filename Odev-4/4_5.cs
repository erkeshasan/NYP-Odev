Console.WriteLine(AritmetikOrtalama(1, 2, 3, 4, 10031.0025));

static double AritmetikOrtalama(params double[] sayılar)
{
    double toplam = 0;

    foreach (double sayı in sayılar)
    {
        toplam = toplam + sayı;
    }

    return toplam / sayılar.Length;
}