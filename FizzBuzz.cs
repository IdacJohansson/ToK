class FizzBuzz
{
    public static void Run()
    {
        int x = 2;
        int y = 3;
        int N = 7;

        for (int i = 1; i <= N; i++)
        {
            if (i % x == 0 && i % y == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % y == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % x == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(i);
            }

        }
    }

}