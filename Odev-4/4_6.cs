Console.WriteLine(FiltreliToplam(new int[] { 0, 12, 13, 14, 15, 16, 17, 18, 20, 30 }, 18));

static double FiltreliToplam(int[] Dizi, int Filtre)
{
    int toplam = 0;

    foreach (int i in Dizi)
    {
        if (i > Filtre)
        {
            toplam = toplam + i;
        }
    }

    return toplam;
}
