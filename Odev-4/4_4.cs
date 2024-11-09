Console.WriteLine(Fibonacci(9));

static int Fibonacci(int Terim)
{
    if (Terim <= 1)
        return Terim;

    return Fibonacci(Terim - 2) + Fibonacci(Terim - 1);
}
