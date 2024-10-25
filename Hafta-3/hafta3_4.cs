Console.Write("Terim Sayısı: ");
int terim = Convert.ToInt32(Console.ReadLine());

long[] fibonacci = new long[terim];
fibonacci[0] = 0;
fibonacci[1] = 1;

for (int hesap = 2; hesap < terim; hesap++)
{
    long toplam = fibonacci[hesap - 2] + fibonacci[hesap - 1];
    fibonacci[hesap] = toplam;
}

foreach (int sonuc in fibonacci)
{
    Console.Write(sonuc + " ");
}
