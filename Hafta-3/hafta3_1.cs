List<int> ArrayList = new List<int>();

ArrayList.Add(12);
ArrayList.Add(15);
ArrayList.Add(29);
ArrayList.Add(362);

int toplam = 0;

foreach (int v in ArrayList)
{
    Console.WriteLine(v);
    toplam += v;
}

Console.WriteLine("Toplam: " + toplam);
