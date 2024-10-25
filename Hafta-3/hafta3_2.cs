Console.Write("Cümle Giriniz: ");
string girdi = Console.ReadLine();

int sayi = 0;

foreach (string kelime in girdi.Split(' '))
{
    sayi++;
}

Console.WriteLine("Kelime Sayısı: " + sayi);
