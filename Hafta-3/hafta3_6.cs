bool devam = true;

do
{
    Console.Write("İşlem: ");
    string işlem = Console.ReadLine();

    if (işlem.ToLower() == "çıkış")
    {
        devam = false;
    }
    else
    {
        Console.Write("Sayı 1: ");
        double.TryParse(Console.ReadLine(), out double sayı_1);

        Console.Write("Sayı 2: ");
        double.TryParse(Console.ReadLine(), out double sayı_2);

        double sonuç = 0;
        bool geçerli = true;

        switch (işlem)
        {
            case "+":
                sonuç = sayı_1 + sayı_2;
                break;
            case "-":
                sonuç = sayı_1 - sayı_2;
                break;
            case "*":
                sonuç = sayı_1 * sayı_2;
                break;
            case "/":
                if (sayı_2 == 0)
                {
                    geçerli = false;
                    Console.Write("Sıfıra bölünmez\n\n");
                }
                else
                {
                    sonuç = sayı_1 / sayı_2;
                }
                break;
            default:
                geçerli = false;
                Console.Write("Bilinmeyen işlem\n\n");
                break;
        }

        if (geçerli)
        {
            Console.Write(sayı_1 + " " + işlem + " " + sayı_2 + " = " + sonuç + "\n\n");
        }
    }
} while (devam);
