Random random = new Random();

while (true)
{
    int sayı = random.Next(1, 10000);
    int deneme = 0;
    bool devam = true;

    Console.Write("\n1 ile 10000 arasında sayı tahmin edin\n\n");

    while (devam)
    {
        int tahmin = Convert.ToInt32(Console.ReadLine());

        if (tahmin < 1 || tahmin > 10000)
        {
            Console.WriteLine("Tahmin 1 ile 10000 arasında olmalıdır");
        }
        else
        {
            deneme++;

            Console.Write("Tahmin #" + deneme + ": ");

            if (tahmin == sayı)
            {
                Console.WriteLine(tahmin + " doğru!");
                Thread.Sleep(2000);
                devam = false;
            }
            else if (tahmin < sayı)
            {
                Console.WriteLine("Tahmin fazla düşük");
            }
            else
            {
                Console.WriteLine("Tahmin fazla yüksek");
            }
        }
    }
}
