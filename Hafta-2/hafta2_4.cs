Console.Write("Sıcaklık: ");

double Temperature = Convert.ToDouble(Console.ReadLine());

if (Temperature >= 10 && Temperature < 20)
{
    Console.WriteLine("Normal");
}
else if (Temperature >= 20 && Temperature < 30)
{
    Console.WriteLine("Sıcak");
}
else if (Temperature >= 30 && Temperature <= 40)
{
    Console.WriteLine("Çok Sıcak");
}
