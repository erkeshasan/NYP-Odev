Console.WriteLine(Matematik.Fibonacci(9));

class Matematik
{
    public static int Fibonacci(int Terim)
    {
        if (Terim <= 1)
            return Terim;

        return Fibonacci(Terim - 2) + Fibonacci(Terim - 1);
    }
}
