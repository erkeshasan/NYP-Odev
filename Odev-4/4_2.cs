Console.WriteLine(EnBüyükBul(new int[] { -150, 150, 23, 4, 0, 90, 7300, 620 }));

static double EnBüyükBul(int[] Dizi)
{
    int enBüyük = Dizi[0];

    foreach (int i in Dizi)
    {
        if (i > enBüyük)
        {
            enBüyük = i;
        }
    }

    return enBüyük;
}
