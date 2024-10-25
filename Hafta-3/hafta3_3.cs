List<string> ArrayList = new List<string>();

for (int i = 1; i < 6; i++)
{
    Console.Write("İsim " + i + " Giriniz: ");
    string isim = Console.ReadLine();
    ArrayList.Add(isim);
}

ArrayList.Sort();

foreach (string v in ArrayList)
{
    Console.WriteLine(v);
}
