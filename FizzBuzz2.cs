class FizzBuzz2
{
    public static void Run()
    {

        int N = 3; // antal spelare
        int M = 15; // antal tal

        // 3 15
        string[,] input1 = new string[,] {
        { "1", "2", "fizz", "4", "5", "fizz", "7", "8", "fizz", "10", "11", "fizz", "13", "14", "fizz" },
        { "1", "2", "3", "4", "buzz", "6", "7", "8", "9", "buzz", "11", "12", "13", "14", "buzz" },
        { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz" } };

        // 3 6
        string[,] input2 = new string[,]{
        { "fizz", "fizz", "fizz", "fizz", "buzz", "fizz" },
        { "2", "fizz", "4", "buzz", "fizz", "7" },
        { "1", "2", "3", "4", "5", "6" }};

        // 2 6
        string[,] input3 = new string[,]{
        {"2" ,"6", "", "", "", "" },
        {"01", "is", "fizz", "lizzy", "of", "norway" },
        {"nr", "2", "is", "really", "buzz", "lightyear"}};

        string[] fizzBuzz = new string[M]; // ny lista
        for (int i = 1; i <= M; i++)
        {
            string res = "";
            if (i % 3 == 0 && i % 5 == 0)
            {
                res += "fizzbuzz";
            }
            if (i % 3 == 0)
            {
                res += "fizz";
            }
            if (i % 5 == 0)
            {
                res += "buzz";
            }
            if (res == "")
            {
                res = i.ToString();
            }
            fizzBuzz[i - 1] = res;
        }

        int[] score = new int[N];
        for (int k = 0; k < N; k++)
        {
            for (int j = 0; j < M; j++)
            {
                if (input1[k, j] == fizzBuzz[j])
                    score[k]++;

            }
        }
        
        int winner = 0;
        for (int i = 1; i < N; i++)
        {
            if (score[i] > score[winner]) winner = i;
        }
        Console.WriteLine(winner + 1);
    }

}