class Program
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

    public static void Main()
    {
        Console.WriteLine(CalculateSum(20, 50));
        Console.WriteLine(CalculateSum(20.6, 50.3));
        Console.WriteLine(CalculateSum(20, 50, 30));
    }
}
