Console.WriteLine(AritmetikOrtalama(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20));

static double AritmetikOrtalama(params double[] sayılar)
{
    double toplam = 0;

    foreach (double sayı in sayılar)
    {
        toplam = toplam + sayı;
    }

    return toplam / sayılar.Length;
}
