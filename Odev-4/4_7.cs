class Program
{
    static int YaşBüyüklüğü(int Yaş = 18)
    {
        return Yaş - 18;
    }

    static void Main()
    {
        Console.WriteLine(YaşBüyüklüğü());
        Console.WriteLine(YaşBüyüklüğü(18));
        Console.WriteLine(YaşBüyüklüğü(29));
    }
}
