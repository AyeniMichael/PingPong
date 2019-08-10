using System;

class PingPong
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        for (int integer = 1; integer <= number; integer++)
        {
            if (integer % 3 == 0 && integer % 5 == 0)
            {
                Console.WriteLine("ping-pong");
            }
            else if (integer % 3 == 0)
            {
                Console.WriteLine("ping");
            }
            else if (integer % 5 == 0)
            {
                Console.WriteLine("pong");
            }
            else
            {
                Console.WriteLine(integer);
            }
        }
    }
}