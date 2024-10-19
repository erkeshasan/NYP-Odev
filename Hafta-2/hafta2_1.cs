Console.Write("Sayı Giriniz: ");
int Sayı = Convert.ToInt32(Console.ReadLine());

if (Sayı % 2 == 0)
{
    Console.WriteLine(Sayı + " Çifttir");
} else
{
    Console.WriteLine(Sayı + " Tektir");
}
