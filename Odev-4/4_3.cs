Console.WriteLine(Matematik.CalculateSum(20, 50));
Console.WriteLine(Matematik.CalculateSum(20.6, 50.3));
Console.WriteLine(Matematik.CalculateSum(20, 50, 30));

public static class Matematik
{
    public static int CalculateSum(int Bir, int İki)
    {
        return Bir + İki;
    }

    public static double CalculateSum(double Bir, double İki)
    {
        return Bir + İki;
    }

    public static int CalculateSum(int Bir, int İki, int Üç)
    {
        return Bir + İki + Üç;
    }
}
