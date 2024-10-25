bool devam = true;

Console.WriteLine("Pozitif tamsayılar giriniz");

List<int> list = new List<int>();
int sayı = 1;
int toplam = 0;

while (devam)
{
    Console.Write("Sayı " + sayı + ": ");

    if (int.TryParse(Console.ReadLine(), out int yeni))
    {
        sayı++;

        if (yeni == 0)
        {
            Console.Write("\nToplam: " + toplam + "\n\n");
            devam = false;
        }
        else
        {
            list.Add(yeni);
            toplam = toplam + yeni;
        }
    }
}

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
} 
