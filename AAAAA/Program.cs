// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class PrimeNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        bool[] primes = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            primes[i] = true;
        }

        for (int i = 2; i <= n; i++)
        {
            if (primes[i] == true)
            {
                for (int j = i * 2; j <= n; j += i)
                {
                    primes[j] = false;
                }
            }
        }

        Console.WriteLine("Prime numbers between 1 and " + n + " are: ");
        for (int i = 2; i <= n; i++)
        {
            if (primes[i] == true)
            {
                Console.Write(i + " ");
            }
        }
    }
}


